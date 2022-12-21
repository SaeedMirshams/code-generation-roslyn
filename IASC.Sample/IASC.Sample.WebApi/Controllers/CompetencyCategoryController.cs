using IASC.Sample.Application.CompetencyCategorys.Commands.CreateCompetencyCategory;
using IASC.Sample.Application.CompetencyCategorys.Commands.DeleteCompetencyCategory;
using IASC.Sample.Application.CompetencyCategorys.Commands.UpdateCompetencyCategory;
using IASC.Sample.Application.CompetencyCategorys.Queries.GetCompetencyCategorysWithPagination;
using IASC.Core.Application.DTOs;
using IASC.Core.WebApi;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IASC.Sample.Application.DTOs;
using System.Net;

namespace IASC.Sample.WebUI.Controllers;


public class CompetencyCategorysController : IASCApiControllerBase
{
    private readonly IMediator _mediator;
    public CompetencyCategorysController(IMediator mediator) => _mediator = mediator;
    

    [HttpGet]
    public async Task<ApiResult<PaginatedList<CompetencyCategoryBriefDto>>> GetCompetencyCategorysWithPagination([FromQuery] GetCompetencyCategorysWithPaginationQuery query)
    {
       return new ApiSuccessResult<PaginatedList<CompetencyCategoryBriefDto>>(null, await _mediator.Send(query));
    }

    [HttpPost]
    public async Task<ApiResult<CompetencyCategoryDto>> Create(CreateCompetencyCategoryCommand command)
    {
        return new ApiSuccessResult<CompetencyCategoryDto>( null, await _mediator.Send(command));
    }

    [HttpPut("{id}")]
    public async Task<ApiResult<CompetencyCategoryDto>> Update(int id, UpdateCompetencyCategoryCommand command)
    {
        if (id != command.Id)
        {
            return new ApiErrorResult<CompetencyCategoryDto>(null, null);
        }

        return new ApiSuccessResult<CompetencyCategoryDto>( null, await _mediator.Send(command));


        
    }

    [HttpDelete("{id}")]
    public async Task<ApiResult<object>> Delete(int id)
    {
        await _mediator.Send(new DeleteCompetencyCategoryCommand(id));
        return new ApiSuccessResult<object>( null, null);


        
    }
}
