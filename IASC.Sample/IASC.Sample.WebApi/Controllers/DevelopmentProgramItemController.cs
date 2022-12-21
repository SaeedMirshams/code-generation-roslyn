using IASC.Sample.Application.DevelopmentProgramItems.Commands.CreateDevelopmentProgramItem;
using IASC.Sample.Application.DevelopmentProgramItems.Commands.DeleteDevelopmentProgramItem;
using IASC.Sample.Application.DevelopmentProgramItems.Commands.UpdateDevelopmentProgramItem;
using IASC.Sample.Application.DevelopmentProgramItems.Queries.GetDevelopmentProgramItemsWithPagination;
using IASC.Core.Application.DTOs;
using IASC.Core.WebApi;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IASC.Sample.Application.DTOs;
using System.Net;

namespace IASC.Sample.WebUI.Controllers;


public class DevelopmentProgramItemsController : IASCApiControllerBase
{
    private readonly IMediator _mediator;
    public DevelopmentProgramItemsController(IMediator mediator) => _mediator = mediator;
    

    [HttpGet]
    public async Task<ApiResult<PaginatedList<DevelopmentProgramItemBriefDto>>> GetDevelopmentProgramItemsWithPagination([FromQuery] GetDevelopmentProgramItemsWithPaginationQuery query)
    {
       return new ApiSuccessResult<PaginatedList<DevelopmentProgramItemBriefDto>>(null, await _mediator.Send(query));
    }

    [HttpPost]
    public async Task<ApiResult<DevelopmentProgramItemDto>> Create(CreateDevelopmentProgramItemCommand command)
    {
        return new ApiSuccessResult<DevelopmentProgramItemDto>( null, await _mediator.Send(command));
    }

    [HttpPut("{id}")]
    public async Task<ApiResult<DevelopmentProgramItemDto>> Update(int id, UpdateDevelopmentProgramItemCommand command)
    {
        if (id != command.Id)
        {
            return new ApiErrorResult<DevelopmentProgramItemDto>(null, null);
        }

        return new ApiSuccessResult<DevelopmentProgramItemDto>( null, await _mediator.Send(command));


        
    }

    [HttpDelete("{id}")]
    public async Task<ApiResult<object>> Delete(int id)
    {
        await _mediator.Send(new DeleteDevelopmentProgramItemCommand(id));
        return new ApiSuccessResult<object>( null, null);


        
    }
}
