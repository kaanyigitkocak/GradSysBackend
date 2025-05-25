using Application.Features.Users.Constants;
using Application.Features.Users.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Pipelines.Authorization;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Users.Queries.GetById;

public class GetByIdUserQuery : IRequest<GetByIdUserResponse>
{
    public Guid Id { get; set; }



    public class GetByIdUserQueryHandler : IRequestHandler<GetByIdUserQuery, GetByIdUserResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly UserBusinessRules _userBusinessRules;
        private readonly IUserOperationClaimRepository _userOperationClaimRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly IStaffRepository _staffRepository;

        public GetByIdUserQueryHandler(
            IUserRepository userRepository, 
            IMapper mapper, 
            UserBusinessRules userBusinessRules, 
            IUserOperationClaimRepository userOperationClaimRepository,
            IStudentRepository studentRepository,
            IStaffRepository staffRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _userBusinessRules = userBusinessRules;
            _userOperationClaimRepository = userOperationClaimRepository;
            _studentRepository = studentRepository;
            _staffRepository = staffRepository;
        }

        public async Task<GetByIdUserResponse> Handle(GetByIdUserQuery request, CancellationToken cancellationToken)
        {
            User? user = await _userRepository.GetAsync(
                predicate: b => b.Id.Equals(request.Id),
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await _userBusinessRules.UserShouldBeExistsWhenSelected(user);

            // Kullanıcının yetkilerini al
            IList<OperationClaim> userOperationClaims = await _userOperationClaimRepository.GetOperationClaimsByUserIdAsync(user!.Id);
            
            // Kullanıcının ilk operation claim'ini al (kullanıcının tek bir claim'i olduğu varsayımıyla)
            string? userRole = userOperationClaims.FirstOrDefault()?.Name;

            GetByIdUserResponse response;

            // Role'e göre uygun mapping yap
            if (userRole == "STUDENT")
            {
                var student = await _studentRepository.GetAsync(
                    predicate: s => s.Id == user.Id,
                    include: s => s.Include(x => x.User)
                                  .Include(x => x.Department)
                                  .ThenInclude(d => d.Faculty),
                    enableTracking: false,
                    cancellationToken: cancellationToken
                );

                if (student != null)
                {
                    response = _mapper.Map<GetByIdUserResponse>(student);
                    response.UserRole = userRole;
                }
                else
                {
                    response = _mapper.Map<GetByIdUserResponse>(user);
                    response.UserRole = userRole;
                }
            }
            else if (userRole == "ADVISOR" || userRole == "DEPARTMENT_SECRETARY" || userRole == "DEANS_OFFICE_STAFF" || userRole == "STUDENT_AFFAIRS_STAFF")
            {
                var staff = await _staffRepository.GetAsync(
                    predicate: s => s.Id == user.Id,
                    include: s => s.Include(x => x.User)
                                  .Include(x => x.Department)
                                  .ThenInclude(d => d.Faculty)
                                  .Include(x => x.Faculty),
                    enableTracking: false,
                    cancellationToken: cancellationToken
                );

                if (staff != null)
                {
                    response = _mapper.Map<GetByIdUserResponse>(staff);
                    response.UserRole = userRole;
                }
                else
                {
                    response = _mapper.Map<GetByIdUserResponse>(user);
                    response.UserRole = userRole;
                }
            }
            else
            {
                response = _mapper.Map<GetByIdUserResponse>(user);
                response.UserRole = userRole;
            }

            return response;
        }
    }
}
