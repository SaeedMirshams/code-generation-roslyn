using IASC.Sample.Application.EvaluationResults.Commands.CreateEvaluationResult;
using IASC.Sample.Application.EvaluationResults.Commands.DeleteEvaluationResult;
using IASC.Sample.Application.EvaluationResults.Commands.UpdateEvaluationResult;
using IASC.Sample.Application.EvaluationResults.Queries.GetEvaluationResultsWithPagination;
using IASC.Core.Application.DTOs;
using IASC.Core.WebApi;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IASC.Sample.Application.DTOs;
using System.Net;

namespace IASC.Sample.WebUI.Controllers;


public class EvaluationResultsController : IASCApiControllerBase
{
    private readonly IMediator _mediator;
    public EvaluationResultsController(IMediator mediator) => _mediator = mediator;
    

    [HttpGet]
    public async Task<ApiResult<PaginatedList<EvaluationResultBriefDto>>> GetEvaluationResultsWithPagination([FromQuery] GetEvaluationResultsWithPaginationQuery query)
    {
       return new ApiSuccessResult<PaginatedList<EvaluationResultBriefDto>>(null, await _mediator.Send(query));
    }

    [HttpPost]
    public async Task<ApiResult<EvaluationResultDto>> Create(CreateEvaluationResultCommand command)
    {
        return new ApiSuccessResult<EvaluationResultDto>( null, await _mediator.Send(command));
    }

    [HttpPut("{id}")]
    public async Task<ApiResult<EvaluationResultDto>> Update(int id, UpdateEvaluationResultCommand command)
    {
        if (id != command.Id)
        {
            return new ApiErrorResult<EvaluationResultDto>(null, null);
        }

        return new ApiSuccessResult<EvaluationResultDto>( null, await _mediator.Send(command));


        
    }

    [HttpDelete("{id}")]
    public async Task<ApiResult<object>> Delete(int id)
    {
        await _mediator.Send(new DeleteEvaluationResultCommand(id));
        return new ApiSuccessResult<object>( null, null);


        
    }
}
