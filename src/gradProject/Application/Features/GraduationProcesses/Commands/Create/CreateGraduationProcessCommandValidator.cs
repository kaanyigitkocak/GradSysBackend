using FluentValidation;

namespace Application.Features.GraduationProcesses.Commands.Create;

public class CreateGraduationProcessCommandValidator : AbstractValidator<CreateGraduationProcessCommand>
{
    public CreateGraduationProcessCommandValidator()
    {
        RuleFor(c => c.StudentUserId).NotEmpty();
        RuleFor(c => c.AcademicTerm).NotEmpty();
        RuleFor(c => c.InitiationDate).NotEmpty();
        RuleFor(c => c.Status).NotEmpty();
        RuleFor(c => c.LastUpdateDate).NotEmpty();
        RuleFor(c => c.Notes).NotEmpty();
        RuleFor(c => c.AdvisorUserId).NotEmpty();
        RuleFor(c => c.AdvisorReviewDate).NotEmpty();
        RuleFor(c => c.DeptSecretaryUserId).NotEmpty();
        RuleFor(c => c.DeptSecretaryReviewDate).NotEmpty();
        RuleFor(c => c.DeansOfficeUserId).NotEmpty();
        RuleFor(c => c.DeansOfficeReviewDate).NotEmpty();
        RuleFor(c => c.StudentAffairsUserId).NotEmpty();
        RuleFor(c => c.StudentAffairsReviewDate).NotEmpty();
    }
}