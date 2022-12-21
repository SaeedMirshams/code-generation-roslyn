using IASC.Core.Application.MediatR.Interfaces;
using IASC.Core.Repositories;
using IASC.Sample.Domain.Entities;
using IASC.Sample.Infrastructure.Persistence;
using MediatR;

namespace IASC.Sample.Application.Employees.Commands.DeleteEmployee;

public record DeleteEmployeeCommand(int Id) : IRequestBase;


public class DeleteEmployeeCommandHandler : IRequestBaseHandler<DeleteEmployeeCommand>
{
    private IRepositoryBase<AppDbContext, Employee, int> _EmployeeRepository;

    public DeleteEmployeeCommandHandler(IRepositoryBase<AppDbContext, Employee, int> EmployeeRepository)
    {
        _EmployeeRepository = EmployeeRepository;
    }

    public async Task<Unit> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
    {
        await _EmployeeRepository.DeleteAsync(request.Id,autoSave:true);

        return  Unit.Value;
    }
}
