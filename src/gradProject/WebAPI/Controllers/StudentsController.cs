using Application.Features.Students.Commands.Create;
using Application.Features.Students.Commands.Delete;
using Application.Features.Students.Commands.Update;
using Application.Features.Students.Queries.GetById;
using Application.Features.Students.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateStudentCommand createStudentCommand)
    {
        CreatedStudentResponse response = await Mediator.Send(createStudentCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateStudentCommand updateStudentCommand)
    {
        UpdatedStudentResponse response = await Mediator.Send(updateStudentCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedStudentResponse response = await Mediator.Send(new DeleteStudentCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdStudentResponse response = await Mediator.Send(new GetByIdStudentQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromQuery] Guid? departmentId = null, [FromQuery] Guid? facultyId = null)
    {
        GetListStudentQuery getListStudentQuery = new() 
        { 
            PageRequest = pageRequest,
            DepartmentId = departmentId,
            FacultyId = facultyId
        };
        GetListResponse<GetListStudentListItemDto> response = await Mediator.Send(getListStudentQuery);
        return Ok(response);
    }

    [HttpGet("department/{departmentId}")]
    public async Task<IActionResult> GetByDepartment([FromRoute] Guid departmentId, [FromQuery] PageRequest pageRequest)
    {
        GetListStudentQuery getListStudentQuery = new() 
        { 
            PageRequest = pageRequest,
            DepartmentId = departmentId
        };
        GetListResponse<GetListStudentListItemDto> response = await Mediator.Send(getListStudentQuery);
        return Ok(response);
    }

    [HttpGet("faculty/{facultyId}")]
    public async Task<IActionResult> GetByFaculty([FromRoute] Guid facultyId, [FromQuery] PageRequest pageRequest)
    {
        GetListStudentQuery getListStudentQuery = new() 
        { 
            PageRequest = pageRequest,
            FacultyId = facultyId
        };
        GetListResponse<GetListStudentListItemDto> response = await Mediator.Send(getListStudentQuery);
        return Ok(response);
    }
}