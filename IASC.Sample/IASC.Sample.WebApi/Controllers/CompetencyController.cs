using IASC.Sample.Application.Competencys.Commands.CreateCompetency;
using IASC.Sample.Application.Competencys.Commands.DeleteCompetency;
using IASC.Sample.Application.Competencys.Commands.UpdateCompetency;
using IASC.Sample.Application.Competencys.Queries.GetCompetencysWithPagination;
using IASC.Core.Application.DTOs;
using IASC.Core.WebApi;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IASC.Sample.Application.DTOs;
using System.Net;

namespace IASC.Sample.WebUI.Controllers;


public class CompetencysController : IASCApiControllerBase
{
    private readonly IMediator _mediator;
    public CompetencysController(IMediator mediator) => _mediator = mediator;
    

    [HttpGet]
    public async Task<ApiResult<PaginatedList<CompetencyBriefDto>>> GetCompetencysWithPagination([FromQuery] GetCompetencysWithPaginationQuery query)
    {
       return new ApiSuccessResult<PaginatedList<CompetencyBriefDto>>(null, await _mediator.Send(query));
    }

    [HttpPost]
    public async Task<ApiResult<CompetencyDto>> Create(CreateCompetencyCommand command)
    {
        return new ApiSuccessResult<CompetencyDto>( null, await _mediator.Send(command));
    }

    [HttpPut("{id}")]
    public async Task<ApiResult<CompetencyDto>> Update(int id, UpdateCompetencyCommand command)
    {
        if (id != command.Id)
        {
            return new ApiErrorResult<CompetencyDto>(null, null);
        }

        return new ApiSuccessResult<CompetencyDto>( null, await _mediator.Send(command));


        
    }

    [HttpDelete("{id}")]
    public async Task<ApiResult<object>> Delete(int id)
    {
        await _mediator.Send(new DeleteCompetencyCommand(id));
        return new ApiSuccessResult<object>( null, null);


        
    }
}
