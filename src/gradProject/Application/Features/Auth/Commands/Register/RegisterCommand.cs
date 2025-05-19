using Application.Constants;
using Application.Features.Auth.Rules;
using Application.Services.AuthService;
using Application.Services.Repositories;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Dtos;
using NArchitecture.Core.Security.Hashing;
using NArchitecture.Core.Security.JWT;
using System.Text.Json.Serialization;

namespace Application.Features.Auth.Commands.Register;

public class UserForRegisterDto : IDto
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    
    // Öğrenci özellikleri
    public string StudentNumber { get; set; } = string.Empty;
    public Guid DepartmentId { get; set; }
    public Guid FacultyId { get; set; }
}

public class RegisterCommand : IRequest<RegisteredResponse>
{
    public UserForRegisterDto UserForRegisterDto { get; set; }
    public string IpAddress { get; set; }

    public RegisterCommand()
    {
        UserForRegisterDto = null!;
        IpAddress = string.Empty;
    }

    public RegisterCommand(UserForRegisterDto userForRegisterDto, string ipAddress)
    {
        UserForRegisterDto = userForRegisterDto;
        IpAddress = ipAddress;
    }

    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisteredResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly IAuthService _authService;
        private readonly AuthBusinessRules _authBusinessRules;
        private readonly IOperationClaimRepository _operationClaimRepository;
        private readonly IUserOperationClaimRepository _userOperationClaimRepository;

        public RegisterCommandHandler(
            IUserRepository userRepository,
            IStudentRepository studentRepository,
            IAuthService authService,
            AuthBusinessRules authBusinessRules,
            IOperationClaimRepository operationClaimRepository,
            IUserOperationClaimRepository userOperationClaimRepository
        )
        {
            _userRepository = userRepository;
            _studentRepository = studentRepository;
            _authService = authService;
            _authBusinessRules = authBusinessRules;
            _operationClaimRepository = operationClaimRepository;
            _userOperationClaimRepository = userOperationClaimRepository;
        }

        public async Task<RegisteredResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            await _authBusinessRules.UserEmailShouldBeNotExists(request.UserForRegisterDto.Email);

            HashingHelper.CreatePasswordHash(
                request.UserForRegisterDto.Password,
                passwordHash: out byte[] passwordHash,
                passwordSalt: out byte[] passwordSalt
            );

            User newUser = new()
            {
                Email = request.UserForRegisterDto.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                FirstName = request.UserForRegisterDto.FirstName,
                LastName = request.UserForRegisterDto.LastName,
                PhoneNumber = request.UserForRegisterDto.PhoneNumber,
                UserName = request.UserForRegisterDto.Email, // UserName için Email kullanılabilir veya ayrı bir alan eklenebilir
                IsActive = true,
                IsEmailVerified = false // E-posta doğrulaması sonradan yapılabilir
            };

            User createdUser = await _userRepository.AddAsync(newUser);

            Student student = new()
            {
                Id = createdUser.Id, // User Id'si Student Id'si olarak atanır (TPT)
                StudentNumber = request.UserForRegisterDto.StudentNumber,
                DepartmentId = request.UserForRegisterDto.DepartmentId,
                ProgramName = "", // ProgramName DTO'dan gelmiyorsa varsayılan veya sonra güncellenecek bir değer
                EnrollDate = DateTime.UtcNow,
                GraduationStatus = Domain.Enums.StudentGraduationStatus.ACTIVE_STUDENT, // Varsayılan mezuniyet durumu
                CurrentGpa = 0, // Varsayılan GPA
                CurrentEctsCompleted = 0 // Varsayılan ECTS
                // FacultyId alanı Student entity'sinde yok, bu yüzden kaldırıldı.
                // Gerekirse Student entity'sine eklenebilir.
            };
            
            await _studentRepository.AddAsync(student);
            
            // Öğrenci rolünü ekle
            OperationClaim? studentOperationClaim = await _operationClaimRepository.GetAsync(
                predicate: oc => oc.Name == BaseOperationClaims.Student,
                cancellationToken: cancellationToken
            );
            
            if (studentOperationClaim == null)
            {
                // Öğrenci rolü yoksa oluştur
                studentOperationClaim = new OperationClaim { Name = BaseOperationClaims.Student };
                studentOperationClaim = await _operationClaimRepository.AddAsync(studentOperationClaim);
            }
            
            // Kullanıcıya öğrenci rolünü ata
            UserOperationClaim userOperationClaim = new()
            {
                UserId = createdUser.Id,
                OperationClaimId = studentOperationClaim.Id
            };
            
            await _userOperationClaimRepository.AddAsync(userOperationClaim);

            AccessToken createdAccessToken = await _authService.CreateAccessToken(createdUser);

            Domain.Entities.RefreshToken createdRefreshToken = await _authService.CreateRefreshToken(
                createdUser,
                request.IpAddress
            );
            Domain.Entities.RefreshToken addedRefreshToken = await _authService.AddRefreshToken(createdRefreshToken);

            RegisteredResponse registeredResponse = new() { AccessToken = createdAccessToken, RefreshToken = addedRefreshToken };
            return registeredResponse;
        }
    }
}
