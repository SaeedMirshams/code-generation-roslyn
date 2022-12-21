using IASC.Sample.Application.Exams.Commands.CreateExam;
using IASC.Sample.Application.Exams.Commands.DeleteExam;
using IASC.Sample.Application.Exams.Commands.UpdateExam;
using IASC.Sample.Application.Exams.Queries.GetExamsWithPagination;
using IASC.Core.Application.DTOs;
using IASC.Core.WebApi;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IASC.Sample.Application.DTOs;
using System.Net;

namespace IASC.Sample.WebUI.Controllers;


public class ExamsController : IASCApiControllerBase
{
    private readonly IMediator _mediator;
    public ExamsController(IMediator mediator) => _mediator = mediator;
    

    [HttpGet]
    public async Task<ApiResult<PaginatedList<ExamBriefDto>>> GetExamsWithPagination([FromQuery] GetExamsWithPaginationQuery query)
    {
       return new ApiSuccessResult<PaginatedList<ExamBriefDto>>(null, await _mediator.Send(query));
    }

    [HttpPost]
    public async Task<ApiResult<ExamDto>> Create(CreateExamCommand command)
    {
        return new ApiSuccessResult<ExamDto>( null, await _mediator.Send(command));
    }

    [HttpPut("{id}")]
    public async Task<ApiResult<ExamDto>> Update(int id, UpdateExamCommand command)
    {
        if (id != command.Id)
        {
            return new ApiErrorResult<ExamDto>(null, null);
        }

        return new ApiSuccessResult<ExamDto>( null, await _mediator.Send(command));


        
    }

    [HttpDelete("{id}")]
    public async Task<ApiResult<object>> Delete(int id)
    {
        await _mediator.Send(new DeleteExamCommand(id));
        return new ApiSuccessResult<object>( null, null);


        
    }
}
