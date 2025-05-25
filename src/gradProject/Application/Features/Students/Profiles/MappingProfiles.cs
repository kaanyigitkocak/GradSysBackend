using Application.Features.Students.Commands.Create;
using Application.Features.Students.Commands.Delete;
using Application.Features.Students.Commands.Update;
using Application.Features.Students.Queries.GetById;
using Application.Features.Students.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using Domain.Enums;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.Students.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Student, CreateStudentCommand>().ReverseMap();
        CreateMap<Student, CreatedStudentResponse>().ReverseMap();
        CreateMap<Student, UpdateStudentCommand>().ReverseMap();
        CreateMap<Student, UpdatedStudentResponse>().ReverseMap();
        CreateMap<Student, DeleteStudentCommand>().ReverseMap();
        CreateMap<Student, DeletedStudentResponse>().ReverseMap();
        CreateMap<Student, GetByIdStudentResponse>()
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.User.FirstName))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.User.LastName))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User.Email))
            .ReverseMap();
        CreateMap<Student, GetListStudentListItemDto>()
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.User.FirstName))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.User.LastName))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User.Email))
            .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.Name))
            .ForMember(dest => dest.FacultyId, opt => opt.MapFrom(src => src.Department.FacultyId))
            .ForMember(dest => dest.FacultyName, opt => opt.MapFrom(src => src.Department.Faculty.Name))
            .ForMember(dest => dest.ActiveGraduationProcessId, opt => opt.MapFrom(src => (Guid?)null))
            .ForMember(dest => dest.ActiveGraduationProcessStatus, opt => opt.MapFrom(src => (GraduationProcessStatus?)null))
            .ForMember(dest => dest.ActiveGraduationProcessAcademicTerm, opt => opt.MapFrom(src => (string?)null))
            .ForMember(dest => dest.ActiveGraduationProcessInitiationDate, opt => opt.MapFrom(src => (DateTime?)null))
            .ForMember(dest => dest.ActiveGraduationProcessLastUpdateDate, opt => opt.MapFrom(src => (DateTime?)null))
            .ReverseMap();
        CreateMap<IPaginate<Student>, GetListResponse<GetListStudentListItemDto>>().ReverseMap();
        
        // GraduationProcess to GraduationProcessInfo mapping
        CreateMap<GraduationProcess, GraduationProcessInfo>().ReverseMap();
    }
}