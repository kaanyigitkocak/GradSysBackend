using Application.Features.Users.Commands.Create;
using Application.Features.Users.Commands.Delete;
using Application.Features.Users.Commands.Update;
using Application.Features.Users.Commands.UpdateFromAuth;
using Application.Features.Users.Queries.GetById;
using Application.Features.Users.Queries.GetList;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.Users.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<User, CreateUserCommand>().ReverseMap();
        CreateMap<User, CreatedUserResponse>().ReverseMap();
        CreateMap<User, UpdateUserCommand>().ReverseMap();
        CreateMap<User, UpdatedUserResponse>().ReverseMap();
        CreateMap<User, UpdateUserFromAuthCommand>().ReverseMap();
        CreateMap<User, UpdatedUserFromAuthResponse>().ReverseMap();
        CreateMap<User, DeleteUserCommand>().ReverseMap();
        CreateMap<User, DeletedUserResponse>().ReverseMap();
        
        // User to GetByIdUserResponse mapping with custom configuration
        CreateMap<User, GetByIdUserResponse>()
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsActive));

        // Student to GetByIdUserResponse mapping
        CreateMap<Student, GetByIdUserResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.User.FirstName))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.User.LastName))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User.Email))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.User.IsActive))
            .ForMember(dest => dest.StudentNumber, opt => opt.MapFrom(src => src.StudentNumber))
            .ForMember(dest => dest.CurrentGpa, opt => opt.MapFrom(src => src.CurrentGpa))
            .ForMember(dest => dest.CurrentEctsCompleted, opt => opt.MapFrom(src => src.CurrentEctsCompleted))
            .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
            .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.Name))
            .ForMember(dest => dest.FacultyId, opt => opt.MapFrom(src => src.Department.FacultyId))
            .ForMember(dest => dest.FacultyName, opt => opt.MapFrom(src => src.Department.Faculty.Name));

        // Staff to GetByIdUserResponse mapping
        CreateMap<Staff, GetByIdUserResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.User.FirstName))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.User.LastName))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User.Email))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.User.IsActive))
            .ForMember(dest => dest.StaffIdentificationNumber, opt => opt.MapFrom(src => src.StaffIdentificationNumber))
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
            .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.Name))
            .ForMember(dest => dest.FacultyId, opt => opt.MapFrom(src => src.FacultyId ?? src.Department.FacultyId))
            .ForMember(dest => dest.FacultyName, opt => opt.MapFrom(src => src.Faculty.Name ?? src.Department.Faculty.Name));

        CreateMap<User, GetListUserListItemDto>().ReverseMap();
        CreateMap<IPaginate<User>, GetListResponse<GetListUserListItemDto>>().ReverseMap();
    }
}
