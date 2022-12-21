using IASC.Sample.Application.Employees.Commands.CreateEmployee;
using IASC.Sample.Application.Employees.Commands.DeleteEmployee;
using IASC.Sample.Application.Employees.Commands.UpdateEmployee;
using IASC.Sample.Application.Employees.Queries.GetEmployeesWithPagination;
using IASC.Core.Application.DTOs;
using IASC.Core.WebApi;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IASC.Sample.Application.DTOs;
using System.Net;

namespace IASC.Sample.WebUI.Controllers;


public class EmployeesController : IASCApiControllerBase
{
    private readonly IMediator _mediator;
    public EmployeesController(IMediator mediator) => _mediator = mediator;
    

    [HttpGet]
    public async Task<ApiResult<PaginatedList<EmployeeBriefDto>>> GetEmployeesWithPagination([FromQuery] GetEmployeesWithPaginationQuery query)
    {
       return new ApiSuccessResult<PaginatedList<EmployeeBriefDto>>(null, await _mediator.Send(query));
    }

    [HttpPost]
    public async Task<ApiResult<EmployeeDto>> Create(CreateEmployeeCommand command)
    {
        return new ApiSuccessResult<EmployeeDto>( null, await _mediator.Send(command));
    }

    [HttpPut("{id}")]
    public async Task<ApiResult<EmployeeDto>> Update(int id, UpdateEmployeeCommand command)
    {
        if (id != command.Id)
        {
            return new ApiErrorResult<EmployeeDto>(null, null);
        }

        return new ApiSuccessResult<EmployeeDto>( null, await _mediator.Send(command));


        
    }

    [HttpDelete("{id}")]
    public async Task<ApiResult<object>> Delete(int id)
    {
        await _mediator.Send(new DeleteEmployeeCommand(id));
        return new ApiSuccessResult<object>( null, null);


        
    }
}
