using System.Text.RegularExpressions;
using FluentValidation;

namespace Application.Features.Auth.Commands.Register;

public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
    public RegisterCommandValidator()
    {
        RuleFor(c => c.UserForRegisterDto.Email).NotEmpty().EmailAddress();
        RuleFor(c => c.UserForRegisterDto.Password)
            .NotEmpty()
            .MinimumLength(6)
            .Must(StrongPassword)
            .WithMessage(
                "Şifre en az bir büyük harf, bir küçük harf, bir sayı ve bir özel karakter içermelidir."
            );
        RuleFor(c => c.UserForRegisterDto.FirstName).NotEmpty();
        RuleFor(c => c.UserForRegisterDto.LastName).NotEmpty();
        RuleFor(c => c.UserForRegisterDto.PhoneNumber).NotEmpty();
        
        // Öğrenci doğrulama
        RuleFor(c => c.UserForRegisterDto.StudentNumber).NotEmpty()
            .WithMessage("Öğrenci numarası gereklidir.");
        RuleFor(c => c.UserForRegisterDto.DepartmentId).NotEmpty()
            .WithMessage("Bölüm bilgisi gereklidir.");
        RuleFor(c => c.UserForRegisterDto.FacultyId).NotEmpty()
            .WithMessage("Fakülte bilgisi gereklidir.");
    }

    private bool StrongPassword(string value)
    {
        Regex strongPasswordRegex = new("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", RegexOptions.Compiled);

        return strongPasswordRegex.IsMatch(value);
    }
}
