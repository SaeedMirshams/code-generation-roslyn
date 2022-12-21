using IASC.Core.Application.MediatR.Interfaces;
using IASC.Core.Repositories;
using IASC.Sample.Domain.Entities;
using IASC.Sample.Infrastructure.Persistence;
using MediatR;

namespace IASC.Sample.Application.EvaluationPeriods.Commands.DeleteEvaluationPeriod;

public record DeleteEvaluationPeriodCommand(int Id) : IRequestBase;


public class DeleteEvaluationPeriodCommandHandler : IRequestBaseHandler<DeleteEvaluationPeriodCommand>
{
    private IRepositoryBase<AppDbContext, EvaluationPeriod, int> _EvaluationPeriodRepository;

    public DeleteEvaluationPeriodCommandHandler(IRepositoryBase<AppDbContext, EvaluationPeriod, int> EvaluationPeriodRepository)
    {
        _EvaluationPeriodRepository = EvaluationPeriodRepository;
    }

    public async Task<Unit> Handle(DeleteEvaluationPeriodCommand request, CancellationToken cancellationToken)
    {
        await _EvaluationPeriodRepository.DeleteAsync(request.Id,autoSave:true);

        return  Unit.Value;
    }
}
