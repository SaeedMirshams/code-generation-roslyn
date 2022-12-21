using IASC.Sample.Application.EvaluationPeriods.Commands.CreateEvaluationPeriod;
using IASC.Sample.Application.EvaluationPeriods.Commands.DeleteEvaluationPeriod;
using IASC.Sample.Application.EvaluationPeriods.Commands.UpdateEvaluationPeriod;
using IASC.Sample.Application.EvaluationPeriods.Queries.GetEvaluationPeriodsWithPagination;
using IASC.Core.Application.DTOs;
using IASC.Core.WebApi;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IASC.Sample.Application.DTOs;
using System.Net;

namespace IASC.Sample.WebUI.Controllers;


public class EvaluationPeriodsController : IASCApiControllerBase
{
    private readonly IMediator _mediator;
    public EvaluationPeriodsController(IMediator mediator) => _mediator = mediator;
    

    [HttpGet]
    public async Task<ApiResult<PaginatedList<EvaluationPeriodBriefDto>>> GetEvaluationPeriodsWithPagination([FromQuery] GetEvaluationPeriodsWithPaginationQuery query)
    {
       return new ApiSuccessResult<PaginatedList<EvaluationPeriodBriefDto>>(null, await _mediator.Send(query));
    }

    [HttpPost]
    public async Task<ApiResult<EvaluationPeriodDto>> Create(CreateEvaluationPeriodCommand command)
    {
        return new ApiSuccessResult<EvaluationPeriodDto>( null, await _mediator.Send(command));
    }

    [HttpPut("{id}")]
    public async Task<ApiResult<EvaluationPeriodDto>> Update(int id, UpdateEvaluationPeriodCommand command)
    {
        if (id != command.Id)
        {
            return new ApiErrorResult<EvaluationPeriodDto>(null, null);
        }

        return new ApiSuccessResult<EvaluationPeriodDto>( null, await _mediator.Send(command));


        
    }

    [HttpDelete("{id}")]
    public async Task<ApiResult<object>> Delete(int id)
    {
        await _mediator.Send(new DeleteEvaluationPeriodCommand(id));
        return new ApiSuccessResult<object>( null, null);


        
    }
}
