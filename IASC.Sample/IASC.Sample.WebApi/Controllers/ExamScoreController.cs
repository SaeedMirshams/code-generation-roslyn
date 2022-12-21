using IASC.Sample.Application.ExamScores.Commands.CreateExamScore;
using IASC.Sample.Application.ExamScores.Commands.DeleteExamScore;
using IASC.Sample.Application.ExamScores.Commands.UpdateExamScore;
using IASC.Sample.Application.ExamScores.Queries.GetExamScoresWithPagination;
using IASC.Core.Application.DTOs;
using IASC.Core.WebApi;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IASC.Sample.Application.DTOs;
using System.Net;

namespace IASC.Sample.WebUI.Controllers;


public class ExamScoresController : IASCApiControllerBase
{
    private readonly IMediator _mediator;
    public ExamScoresController(IMediator mediator) => _mediator = mediator;
    

    [HttpGet]
    public async Task<ApiResult<PaginatedList<ExamScoreBriefDto>>> GetExamScoresWithPagination([FromQuery] GetExamScoresWithPaginationQuery query)
    {
       return new ApiSuccessResult<PaginatedList<ExamScoreBriefDto>>(null, await _mediator.Send(query));
    }

    [HttpPost]
    public async Task<ApiResult<ExamScoreDto>> Create(CreateExamScoreCommand command)
    {
        return new ApiSuccessResult<ExamScoreDto>( null, await _mediator.Send(command));
    }

    [HttpPut("{id}")]
    public async Task<ApiResult<ExamScoreDto>> Update(int id, UpdateExamScoreCommand command)
    {
        if (id != command.Id)
        {
            return new ApiErrorResult<ExamScoreDto>(null, null);
        }

        return new ApiSuccessResult<ExamScoreDto>( null, await _mediator.Send(command));


        
    }

    [HttpDelete("{id}")]
    public async Task<ApiResult<object>> Delete(int id)
    {
        await _mediator.Send(new DeleteExamScoreCommand(id));
        return new ApiSuccessResult<object>( null, null);


        
    }
}
