using IASC.Core.Application.MediatR.Interfaces;
using IASC.Core.Repositories;
using IASC.Sample.Domain.Entities;
using IASC.Sample.Infrastructure.Persistence;
using MediatR;

namespace IASC.Sample.Application.ExamParameters.Commands.DeleteExamParameter;

public record DeleteExamParameterCommand(int Id) : IRequestBase;


public class DeleteExamParameterCommandHandler : IRequestBaseHandler<DeleteExamParameterCommand>
{
    private IRepositoryBase<AppDbContext, ExamParameter, int> _ExamParameterRepository;

    public DeleteExamParameterCommandHandler(IRepositoryBase<AppDbContext, ExamParameter, int> ExamParameterRepository)
    {
        _ExamParameterRepository = ExamParameterRepository;
    }

    public async Task<Unit> Handle(DeleteExamParameterCommand request, CancellationToken cancellationToken)
    {
        await _ExamParameterRepository.DeleteAsync(request.Id,autoSave:true);

        return  Unit.Value;
    }
}
