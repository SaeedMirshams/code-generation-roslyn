using IASC.Sample.Application.PostCompetencys.Commands.CreatePostCompetency;
using IASC.Sample.Application.PostCompetencys.Commands.DeletePostCompetency;
using IASC.Sample.Application.PostCompetencys.Commands.UpdatePostCompetency;
using IASC.Sample.Application.PostCompetencys.Queries.GetPostCompetencysWithPagination;
using IASC.Core.Application.DTOs;
using IASC.Core.WebApi;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IASC.Sample.Application.DTOs;
using System.Net;

namespace IASC.Sample.WebUI.Controllers;


public class PostCompetencysController : IASCApiControllerBase
{
    private readonly IMediator _mediator;
    public PostCompetencysController(IMediator mediator) => _mediator = mediator;
    

    [HttpGet]
    public async Task<ApiResult<PaginatedList<PostCompetencyBriefDto>>> GetPostCompetencysWithPagination([FromQuery] GetPostCompetencysWithPaginationQuery query)
    {
       return new ApiSuccessResult<PaginatedList<PostCompetencyBriefDto>>(null, await _mediator.Send(query));
    }

    [HttpPost]
    public async Task<ApiResult<PostCompetencyDto>> Create(CreatePostCompetencyCommand command)
    {
        return new ApiSuccessResult<PostCompetencyDto>( null, await _mediator.Send(command));
    }

    [HttpPut("{id}")]
    public async Task<ApiResult<PostCompetencyDto>> Update(int id, UpdatePostCompetencyCommand command)
    {
        if (id != command.Id)
        {
            return new ApiErrorResult<PostCompetencyDto>(null, null);
        }

        return new ApiSuccessResult<PostCompetencyDto>( null, await _mediator.Send(command));


        
    }

    [HttpDelete("{id}")]
    public async Task<ApiResult<object>> Delete(int id)
    {
        await _mediator.Send(new DeletePostCompetencyCommand(id));
        return new ApiSuccessResult<object>( null, null);


        
    }
}
