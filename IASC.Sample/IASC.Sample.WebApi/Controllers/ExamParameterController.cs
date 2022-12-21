using IASC.Sample.Application.ExamParameters.Commands.CreateExamParameter;
using IASC.Sample.Application.ExamParameters.Commands.DeleteExamParameter;
using IASC.Sample.Application.ExamParameters.Commands.UpdateExamParameter;
using IASC.Sample.Application.ExamParameters.Queries.GetExamParametersWithPagination;
using IASC.Core.Application.DTOs;
using IASC.Core.WebApi;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IASC.Sample.Application.DTOs;
using System.Net;

namespace IASC.Sample.WebUI.Controllers;


public class ExamParametersController : IASCApiControllerBase
{
    private readonly IMediator _mediator;
    public ExamParametersController(IMediator mediator) => _mediator = mediator;
    

    [HttpGet]
    public async Task<ApiResult<PaginatedList<ExamParameterBriefDto>>> GetExamParametersWithPagination([FromQuery] GetExamParametersWithPaginationQuery query)
    {
       return new ApiSuccessResult<PaginatedList<ExamParameterBriefDto>>(null, await _mediator.Send(query));
    }

    [HttpPost]
    public async Task<ApiResult<ExamParameterDto>> Create(CreateExamParameterCommand command)
    {
        return new ApiSuccessResult<ExamParameterDto>( null, await _mediator.Send(command));
    }

    [HttpPut("{id}")]
    public async Task<ApiResult<ExamParameterDto>> Update(int id, UpdateExamParameterCommand command)
    {
        if (id != command.Id)
        {
            return new ApiErrorResult<ExamParameterDto>(null, null);
        }

        return new ApiSuccessResult<ExamParameterDto>( null, await _mediator.Send(command));


        
    }

    [HttpDelete("{id}")]
    public async Task<ApiResult<object>> Delete(int id)
    {
        await _mediator.Send(new DeleteExamParameterCommand(id));
        return new ApiSuccessResult<object>( null, null);


        
    }
}
