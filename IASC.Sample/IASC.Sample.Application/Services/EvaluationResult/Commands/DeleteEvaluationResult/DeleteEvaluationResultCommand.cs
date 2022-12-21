using IASC.Core.Application.MediatR.Interfaces;
using IASC.Core.Repositories;
using IASC.Sample.Domain.Entities;
using IASC.Sample.Infrastructure.Persistence;
using MediatR;

namespace IASC.Sample.Application.EvaluationResults.Commands.DeleteEvaluationResult;

public record DeleteEvaluationResultCommand(int Id) : IRequestBase;


public class DeleteEvaluationResultCommandHandler : IRequestBaseHandler<DeleteEvaluationResultCommand>
{
    private IRepositoryBase<AppDbContext, EvaluationResult, int> _EvaluationResultRepository;

    public DeleteEvaluationResultCommandHandler(IRepositoryBase<AppDbContext, EvaluationResult, int> EvaluationResultRepository)
    {
        _EvaluationResultRepository = EvaluationResultRepository;
    }

    public async Task<Unit> Handle(DeleteEvaluationResultCommand request, CancellationToken cancellationToken)
    {
        await _EvaluationResultRepository.DeleteAsync(request.Id,autoSave:true);

        return  Unit.Value;
    }
}
