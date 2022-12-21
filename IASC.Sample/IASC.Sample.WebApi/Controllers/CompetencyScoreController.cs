using IASC.Sample.Application.CompetencyScores.Commands.CreateCompetencyScore;
using IASC.Sample.Application.CompetencyScores.Commands.DeleteCompetencyScore;
using IASC.Sample.Application.CompetencyScores.Commands.UpdateCompetencyScore;
using IASC.Sample.Application.CompetencyScores.Queries.GetCompetencyScoresWithPagination;
using IASC.Core.Application.DTOs;
using IASC.Core.WebApi;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IASC.Sample.Application.DTOs;
using System.Net;

namespace IASC.Sample.WebUI.Controllers;


public class CompetencyScoresController : IASCApiControllerBase
{
    private readonly IMediator _mediator;
    public CompetencyScoresController(IMediator mediator) => _mediator = mediator;
    

    [HttpGet]
    public async Task<ApiResult<PaginatedList<CompetencyScoreBriefDto>>> GetCompetencyScoresWithPagination([FromQuery] GetCompetencyScoresWithPaginationQuery query)
    {
       return new ApiSuccessResult<PaginatedList<CompetencyScoreBriefDto>>(null, await _mediator.Send(query));
    }

    [HttpPost]
    public async Task<ApiResult<CompetencyScoreDto>> Create(CreateCompetencyScoreCommand command)
    {
        return new ApiSuccessResult<CompetencyScoreDto>( null, await _mediator.Send(command));
    }

    [HttpPut("{id}")]
    public async Task<ApiResult<CompetencyScoreDto>> Update(int id, UpdateCompetencyScoreCommand command)
    {
        if (id != command.Id)
        {
            return new ApiErrorResult<CompetencyScoreDto>(null, null);
        }

        return new ApiSuccessResult<CompetencyScoreDto>( null, await _mediator.Send(command));


        
    }

    [HttpDelete("{id}")]
    public async Task<ApiResult<object>> Delete(int id)
    {
        await _mediator.Send(new DeleteCompetencyScoreCommand(id));
        return new ApiSuccessResult<object>( null, null);


        
    }
}
