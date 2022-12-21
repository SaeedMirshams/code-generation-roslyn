using IASC.Sample.Application.CompetencyModels.Commands.CreateCompetencyModel;
using IASC.Sample.Application.CompetencyModels.Commands.DeleteCompetencyModel;
using IASC.Sample.Application.CompetencyModels.Commands.UpdateCompetencyModel;
using IASC.Sample.Application.CompetencyModels.Queries.GetCompetencyModelsWithPagination;
using IASC.Core.Application.DTOs;
using IASC.Core.WebApi;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IASC.Sample.Application.DTOs;
using System.Net;

namespace IASC.Sample.WebUI.Controllers;


public class CompetencyModelsController : IASCApiControllerBase
{
    private readonly IMediator _mediator;
    public CompetencyModelsController(IMediator mediator) => _mediator = mediator;
    

    [HttpGet]
    public async Task<ApiResult<PaginatedList<CompetencyModelBriefDto>>> GetCompetencyModelsWithPagination([FromQuery] GetCompetencyModelsWithPaginationQuery query)
    {
       return new ApiSuccessResult<PaginatedList<CompetencyModelBriefDto>>(null, await _mediator.Send(query));
    }

    [HttpPost]
    public async Task<ApiResult<CompetencyModelDto>> Create(CreateCompetencyModelCommand command)
    {
        return new ApiSuccessResult<CompetencyModelDto>( null, await _mediator.Send(command));
    }

    [HttpPut("{id}")]
    public async Task<ApiResult<CompetencyModelDto>> Update(int id, UpdateCompetencyModelCommand command)
    {
        if (id != command.Id)
        {
            return new ApiErrorResult<CompetencyModelDto>(null, null);
        }

        return new ApiSuccessResult<CompetencyModelDto>( null, await _mediator.Send(command));


        
    }

    [HttpDelete("{id}")]
    public async Task<ApiResult<object>> Delete(int id)
    {
        await _mediator.Send(new DeleteCompetencyModelCommand(id));
        return new ApiSuccessResult<object>( null, null);


        
    }
}
