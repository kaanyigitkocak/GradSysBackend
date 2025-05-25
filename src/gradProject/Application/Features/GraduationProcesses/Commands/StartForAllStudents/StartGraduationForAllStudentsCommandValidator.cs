using FluentValidation;

namespace Application.Features.GraduationProcesses.Commands.StartForAllStudents;

public class StartGraduationForAllStudentsCommandValidator : AbstractValidator<StartGraduationForAllStudentsCommand>
{
    public StartGraduationForAllStudentsCommandValidator()
    {
        RuleFor(c => c.AcademicTerm)
            .NotEmpty().WithMessage("Academic term cannot be empty.")
            .MaximumLength(50).WithMessage("Academic term can be at most 50 characters.")
            .Matches(@"^\d{4}-\d{4}-(Fall|Spring|Summer)$").WithMessage("Academic term format should be like '2023-2024-Fall'.");

        RuleFor(c => c.InitiatedByUserId)
            .NotEmpty().WithMessage("Initiated by user ID cannot be empty.");
    }
} 