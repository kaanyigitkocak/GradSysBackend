
using Application.Features.GraduationProcesses.Commands.StartForAllStudents;
using Application.Features.GraduationProcesses.Queries.GetById;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GraduationProcessesController : BaseController
{

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdGraduationProcessResponse response = await Mediator.Send(new GetByIdGraduationProcessQuery { Id = id });
        return Ok(response);
    }

    [HttpPost("StartForAllStudents")]
    public async Task<IActionResult> StartForAllStudents([FromBody] StartGraduationForAllStudentsCommand command)
    {
        StartedGraduationForAllStudentsResponse response = await Mediator.Send(command);
        return Ok(response);
    }

}