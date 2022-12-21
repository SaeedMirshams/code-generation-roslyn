using IASC.Sample.Application.DevelopmentPrograms.Commands.CreateDevelopmentProgram;
using IASC.Sample.Application.DevelopmentPrograms.Commands.DeleteDevelopmentProgram;
using IASC.Sample.Application.DevelopmentPrograms.Commands.UpdateDevelopmentProgram;
using IASC.Sample.Application.DevelopmentPrograms.Queries.GetDevelopmentProgramsWithPagination;
using IASC.Core.Application.DTOs;
using IASC.Core.WebApi;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IASC.Sample.Application.DTOs;
using System.Net;

namespace IASC.Sample.WebUI.Controllers;


public class DevelopmentProgramsController : IASCApiControllerBase
{
    private readonly IMediator _mediator;
    public DevelopmentProgramsController(IMediator mediator) => _mediator = mediator;
    

    [HttpGet]
    public async Task<ApiResult<PaginatedList<DevelopmentProgramBriefDto>>> GetDevelopmentProgramsWithPagination([FromQuery] GetDevelopmentProgramsWithPaginationQuery query)
    {
       return new ApiSuccessResult<PaginatedList<DevelopmentProgramBriefDto>>(null, await _mediator.Send(query));
    }

    [HttpPost]
    public async Task<ApiResult<DevelopmentProgramDto>> Create(CreateDevelopmentProgramCommand command)
    {
        return new ApiSuccessResult<DevelopmentProgramDto>( null, await _mediator.Send(command));
    }

    [HttpPut("{id}")]
    public async Task<ApiResult<DevelopmentProgramDto>> Update(int id, UpdateDevelopmentProgramCommand command)
    {
        if (id != command.Id)
        {
            return new ApiErrorResult<DevelopmentProgramDto>(null, null);
        }

        return new ApiSuccessResult<DevelopmentProgramDto>( null, await _mediator.Send(command));


        
    }

    [HttpDelete("{id}")]
    public async Task<ApiResult<object>> Delete(int id)
    {
        await _mediator.Send(new DeleteDevelopmentProgramCommand(id));
        return new ApiSuccessResult<object>( null, null);


        
    }
}
