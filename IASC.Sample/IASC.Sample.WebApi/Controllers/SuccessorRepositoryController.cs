using IASC.Sample.Application.SuccessorRepositorys.Commands.CreateSuccessorRepository;
using IASC.Sample.Application.SuccessorRepositorys.Commands.DeleteSuccessorRepository;
using IASC.Sample.Application.SuccessorRepositorys.Commands.UpdateSuccessorRepository;
using IASC.Sample.Application.SuccessorRepositorys.Queries.GetSuccessorRepositorysWithPagination;
using IASC.Core.Application.DTOs;
using IASC.Core.WebApi;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IASC.Sample.Application.DTOs;
using System.Net;

namespace IASC.Sample.WebUI.Controllers;


public class SuccessorRepositorysController : IASCApiControllerBase
{
    private readonly IMediator _mediator;
    public SuccessorRepositorysController(IMediator mediator) => _mediator = mediator;
    

    [HttpGet]
    public async Task<ApiResult<PaginatedList<SuccessorRepositoryBriefDto>>> GetSuccessorRepositorysWithPagination([FromQuery] GetSuccessorRepositorysWithPaginationQuery query)
    {
       return new ApiSuccessResult<PaginatedList<SuccessorRepositoryBriefDto>>(null, await _mediator.Send(query));
    }

    [HttpPost]
    public async Task<ApiResult<SuccessorRepositoryDto>> Create(CreateSuccessorRepositoryCommand command)
    {
        return new ApiSuccessResult<SuccessorRepositoryDto>( null, await _mediator.Send(command));
    }

    [HttpPut("{id}")]
    public async Task<ApiResult<SuccessorRepositoryDto>> Update(int id, UpdateSuccessorRepositoryCommand command)
    {
        if (id != command.Id)
        {
            return new ApiErrorResult<SuccessorRepositoryDto>(null, null);
        }

        return new ApiSuccessResult<SuccessorRepositoryDto>( null, await _mediator.Send(command));


        
    }

    [HttpDelete("{id}")]
    public async Task<ApiResult<object>> Delete(int id)
    {
        await _mediator.Send(new DeleteSuccessorRepositoryCommand(id));
        return new ApiSuccessResult<object>( null, null);


        
    }
}
