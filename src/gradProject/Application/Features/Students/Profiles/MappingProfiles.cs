using Application.Features.Students.Commands.Create;
using Application.Features.Students.Commands.Delete;
using Application.Features.Students.Commands.Update;
using Application.Features.Students.Queries.GetById;
using Application.Features.Students.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
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
        CreateMap<Student, GetByIdStudentResponse>().ReverseMap();
        CreateMap<Student, GetListStudentListItemDto>()
            .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.Name))
            .ForMember(dest => dest.FacultyId, opt => opt.MapFrom(src => src.Department.FacultyId))
            .ForMember(dest => dest.FacultyName, opt => opt.MapFrom(src => src.Department.Faculty.Name))
            .ReverseMap();
        CreateMap<IPaginate<Student>, GetListResponse<GetListStudentListItemDto>>().ReverseMap();
    }
}