using Application.Features.GraduationProcesses.Commands.Create;
using Application.Features.GraduationProcesses.Commands.Delete;
using Application.Features.GraduationProcesses.Commands.Update;
using Application.Features.GraduationProcesses.Queries.GetById;
using Application.Features.GraduationProcesses.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GraduationProcessesController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateGraduationProcessCommand createGraduationProcessCommand)
    {
        CreatedGraduationProcessResponse response = await Mediator.Send(createGraduationProcessCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateGraduationProcessCommand updateGraduationProcessCommand)
    {
        UpdatedGraduationProcessResponse response = await Mediator.Send(updateGraduationProcessCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedGraduationProcessResponse response = await Mediator.Send(new DeleteGraduationProcessCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdGraduationProcessResponse response = await Mediator.Send(new GetByIdGraduationProcessQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListGraduationProcessQuery getListGraduationProcessQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListGraduationProcessListItemDto> response = await Mediator.Send(getListGraduationProcessQuery);
        return Ok(response);
    }
}