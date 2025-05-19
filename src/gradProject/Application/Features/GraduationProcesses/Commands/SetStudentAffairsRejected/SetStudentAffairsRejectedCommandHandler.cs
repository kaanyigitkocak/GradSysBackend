using Application.Services.Repositories;
using Domain.Entities;
using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.GraduationProcesses.Commands.SetStudentAffairsRejected;

public class SetStudentAffairsRejectedCommandHandler : IRequestHandler<SetStudentAffairsRejectedCommand, SetStudentAffairsRejectedResponse>
{
    private readonly IGraduationProcessRepository _graduationProcessRepository;
    private readonly IStudentRepository _studentRepository;
    private readonly INotificationRepository _notificationRepository;

    public SetStudentAffairsRejectedCommandHandler(
        IGraduationProcessRepository graduationProcessRepository,
        IStudentRepository studentRepository,
        INotificationRepository notificationRepository)
    {
        _graduationProcessRepository = graduationProcessRepository;
        _studentRepository = studentRepository;
        _notificationRepository = notificationRepository;
    }

    public async Task<SetStudentAffairsRejectedResponse> Handle(SetStudentAffairsRejectedCommand request, CancellationToken cancellationToken)
    {
        var response = new SetStudentAffairsRejectedResponse
        {
            TotalStudentsInRequest = request.StudentUserIds.Distinct().Count()
        };

        if (!request.StudentUserIds.Any())
        {
            response.OverallMessage = "StudentUserIds list cannot be empty.";
            return response;
        }

        foreach (var studentId in request.StudentUserIds.Distinct())
        {
            var summary = new StudentProcessSummary { StudentUserId = studentId };
            try
            {
                GraduationProcess? graduationProcess = await _graduationProcessRepository.GetAsync(
                    predicate: gp => gp.StudentUserId == studentId &&
                                     gp.Status == GraduationProcessStatus.PENDING_STUDENT_AFFAIRS_FINALIZATION,
                    cancellationToken: cancellationToken
                );

                if (graduationProcess == null)
                {
                    summary.Success = false;
                    summary.Message = $"Graduation process not found for student {studentId} or not in the expected state (PENDING_STUDENT_AFFAIRS_FINALIZATION).";
                    response.FailedToProcessCount++;
                    response.ProcessSummaries.Add(summary);
                    continue;
                }
                summary.GraduationProcessId = graduationProcess.Id;

                Student? student = await _studentRepository.GetAsync(
                    predicate: s => s.Id == studentId,
                    cancellationToken: cancellationToken
                );

                if (student == null)
                {
                    summary.Success = false;
                    summary.Message = $"Student profile not found for ID {studentId}.";
                    response.FailedToProcessCount++;
                    response.ProcessSummaries.Add(summary);
                    continue;
                }

                // Update GraduationProcess
                graduationProcess.Status = GraduationProcessStatus.STUDENT_AFFAIRS_REJECTED;
                graduationProcess.LastUpdateDate = DateTime.UtcNow;
                graduationProcess.StudentAffairsUserId = request.StudentAffairsUserId;
                graduationProcess.StudentAffairsReviewDate = DateTime.UtcNow;
                graduationProcess.Notes = request.RejectionReason;
                await _graduationProcessRepository.UpdateAsync(graduationProcess);
                summary.NewGraduationProcessStatus = graduationProcess.Status;

                // Update Student Status - Reverts to a state indicating need for fundamental re-evaluation.
                student.GraduationStatus = StudentGraduationStatus.PENDING_ELIGIBILITY_REVIEW_BY_ADVISOR;
                student.UpdatedDate = DateTime.UtcNow;
                await _studentRepository.UpdateAsync(student);
                summary.NewStudentGraduationStatus = student.GraduationStatus;

                // Create Notification
                Notification notification = new Notification
                {
                    Id = Guid.NewGuid(),
                    RecipientUserId = studentId,
                    Title = "Graduation Process Update: Student Affairs Rejection",
                    Message = $"Your graduation process has been rejected by Student Affairs. Reason: '{request.RejectionReason}'. Process status: '{graduationProcess.Status.ToString()}'. Student status: '{student.GraduationStatus.ToString()}'. Please contact the Dean's Office or your advisor for next steps.",
                    CreationDate = DateTime.UtcNow,
                    IsRead = false,
                    RelatedProcessId = graduationProcess.Id
                };
                await _notificationRepository.AddAsync(notification);

                summary.Success = true;
                summary.Message = $"Successfully rejected by Student Affairs. Notification sent. Reason: {request.RejectionReason}. Process: {graduationProcess.Status.ToString()}, Student: {student.GraduationStatus.ToString()}.";
                response.SuccessfullyProcessedCount++;
            }
            catch (Exception ex)
            {
                summary.Success = false;
                summary.Message = $"An unexpected error occurred for student {studentId}: {ex.Message}";
                response.FailedToProcessCount++;
            }
            response.ProcessSummaries.Add(summary);
        }

        response.OverallMessage = $"Set Student Affairs Rejected batch process completed. Total: {response.TotalStudentsInRequest}, Succeeded: {response.SuccessfullyProcessedCount}, Failed: {response.FailedToProcessCount}.";
        return response;
    }
} 