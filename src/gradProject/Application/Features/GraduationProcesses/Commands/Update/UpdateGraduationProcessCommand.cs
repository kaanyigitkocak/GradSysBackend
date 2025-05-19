using Application.Features.GraduationProcesses.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using MediatR;

namespace Application.Features.GraduationProcesses.Commands.Update;

public class UpdateGraduationProcessCommand : IRequest<UpdatedGraduationProcessResponse>
{
    public Guid Id { get; set; }
    public Guid StudentUserId { get; set; }
    public string AcademicTerm { get; set; }
    public DateTime InitiationDate { get; set; }
    public GraduationProcessStatus Status { get; set; }
    public DateTime LastUpdateDate { get; set; }
    public string? Notes { get; set; }
    public Guid? AdvisorUserId { get; set; }
    public DateTime? AdvisorReviewDate { get; set; }
    public Guid? DeptSecretaryUserId { get; set; }
    public DateTime? DeptSecretaryReviewDate { get; set; }
    public Guid? DeansOfficeUserId { get; set; }
    public DateTime? DeansOfficeReviewDate { get; set; }
    public Guid? StudentAffairsUserId { get; set; }
    public DateTime? StudentAffairsReviewDate { get; set; }

    public class UpdateGraduationProcessCommandHandler : IRequestHandler<UpdateGraduationProcessCommand, UpdatedGraduationProcessResponse>
    {
        private readonly IMapper _mapper;
        private readonly IGraduationProcessRepository _graduationProcessRepository;
        private readonly GraduationProcessBusinessRules _graduationProcessBusinessRules;

        public UpdateGraduationProcessCommandHandler(IMapper mapper, IGraduationProcessRepository graduationProcessRepository,
                                         GraduationProcessBusinessRules graduationProcessBusinessRules)
        {
            _mapper = mapper;
            _graduationProcessRepository = graduationProcessRepository;
            _graduationProcessBusinessRules = graduationProcessBusinessRules;
        }

        public async Task<UpdatedGraduationProcessResponse> Handle(UpdateGraduationProcessCommand request, CancellationToken cancellationToken)
        {
            GraduationProcess? graduationProcess = await _graduationProcessRepository.GetAsync(predicate: gp => gp.Id == request.Id, cancellationToken: cancellationToken);
            await _graduationProcessBusinessRules.GraduationProcessShouldExistWhenSelected(graduationProcess);
            graduationProcess = _mapper.Map(request, graduationProcess);

            await _graduationProcessRepository.UpdateAsync(graduationProcess!);

            UpdatedGraduationProcessResponse response = _mapper.Map<UpdatedGraduationProcessResponse>(graduationProcess);
            return response;
        }
    }
}