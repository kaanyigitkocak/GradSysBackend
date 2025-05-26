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
using NArchitecture.Core.Application.Pipelines.Validation;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Auth.Commands.Register;

public class UserForRegisterDto : IDto
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    
    // Öğrenci özellikleri
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
        private readonly IDepartmentRepository _departmentRepository;

        public RegisterCommandHandler(
            IUserRepository userRepository,
            IStudentRepository studentRepository,
            IAuthService authService,
            AuthBusinessRules authBusinessRules,
            IOperationClaimRepository operationClaimRepository,
            IUserOperationClaimRepository userOperationClaimRepository,
            IDepartmentRepository departmentRepository
        )
        {
            _userRepository = userRepository;
            _studentRepository = studentRepository;
            _authService = authService;
            _authBusinessRules = authBusinessRules;
            _operationClaimRepository = operationClaimRepository;
            _userOperationClaimRepository = userOperationClaimRepository;
            _departmentRepository = departmentRepository;
        }

        public async Task<RegisteredResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            // Try to find an existing student with the provided details
            Student? student = await _studentRepository.GetAsync(
                predicate: s => 
                    s.User.Email == request.UserForRegisterDto.Email &&
                    s.User.FirstName == request.UserForRegisterDto.FirstName &&
                    s.User.LastName == request.UserForRegisterDto.LastName &&
                    s.DepartmentId == request.UserForRegisterDto.DepartmentId &&
                    s.Department.FacultyId == request.UserForRegisterDto.FacultyId, // Assuming Department entity has FacultyId
                include: s => s.Include(u => u.User).Include(d => d.Department), // Include User and Department for checking
                cancellationToken: cancellationToken
            );

            User? user;

            if (student != null)
            {
                user = student.User; // Get the associated user
                if (user.IsActive)
                {
                    throw new BusinessException("An active account with these details already exists.");
                }
                // User exists but is not active, so we will update and activate them.
            }
            else
            {
                // No existing student found with these exact details. Check if the email is used by another active user.
                await _authBusinessRules.UserEmailShouldBeNotExists(request.UserForRegisterDto.Email);

                // Create a new User
                user = new User
                {
                    Email = request.UserForRegisterDto.Email,
                    FirstName = request.UserForRegisterDto.FirstName,
                    LastName = request.UserForRegisterDto.LastName,
                    UserName = request.UserForRegisterDto.Email, // Or generate a unique username
                    // PhoneNumber can be set to null or an empty string if not collected
                };

                // Create a new Student profile
                student = new Student
                {
                    // StudentNumber will not be set from input, can be generated or left null if not mandatory
                    DepartmentId = request.UserForRegisterDto.DepartmentId,
                    // FacultyId is implicitly checked via Department.FacultyId
                    User = user, // Associate the new user
                    Id = user.Id // Ensure Student.Id is the same as User.Id for consistency
                };
                await _studentRepository.AddAsync(student); // This will also add the user due to EF Core relationship
            }

            // Update common user fields (password, active status, email verified status)
            HashingHelper.CreatePasswordHash(
                request.UserForRegisterDto.Password,
                passwordHash: out byte[] passwordHash,
                passwordSalt: out byte[] passwordSalt
            );
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            user.IsActive = true;
            user.IsEmailVerified = true; 

            // Update the user (if existing) or save the new user (if created via student)
            // If student was new, user is also new and will be saved via studentRepository.AddAsync(student)
            // If student existed, user existed, so we need to update the user.
            if (student != null && user.Id != Guid.Empty) // Check if user was pre-existing
            {
                 await _userRepository.UpdateAsync(user);
            }
            // else: user is new and already added with student. No explicit user add/update needed here.


            // Assign default "Student" role if not already assigned
            // This part might need adjustment based on how roles are managed.
            // For simplicity, let's assume a "Student" role exists and needs to be assigned.
            OperationClaim? studentRole = await _operationClaimRepository.GetAsync(
                predicate: oc => oc.Name == BaseOperationClaims.Student, // Changed from GeneralApplicationConstants.StudentRoleName
                cancellationToken: cancellationToken
            );

            if (studentRole != null)
            {
                // Check if user already has this role, especially if reactivating
                bool hasStudentRole = await _userOperationClaimRepository.AnyAsync(
                    predicate: uoc => uoc.UserId == user.Id && uoc.OperationClaimId == studentRole.Id,
                    cancellationToken: cancellationToken
                );

                if (!hasStudentRole)
                {
                    UserOperationClaim userOperationClaim = new() { UserId = user.Id, OperationClaimId = studentRole.Id };
                    await _userOperationClaimRepository.AddAsync(userOperationClaim);
                }
            }


            AccessToken createdAccessToken = await _authService.CreateAccessToken(user);
            Domain.Entities.RefreshToken createdRefreshToken = await _authService.CreateRefreshToken(user, request.IpAddress);
            Domain.Entities.RefreshToken addedRefreshToken = await _authService.AddRefreshToken(createdRefreshToken);

            RegisteredResponse registeredResponse = new() { AccessToken = createdAccessToken, RefreshToken = addedRefreshToken };
            return registeredResponse;
        }
    }
}
