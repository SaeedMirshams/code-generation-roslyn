using IASC.Core.Application.MediatR.Interfaces;
using IASC.Core.Repositories;
using IASC.Sample.Domain.Entities;
using IASC.Sample.Infrastructure.Persistence;
using MediatR;

namespace IASC.Sample.Application.ExamScores.Commands.DeleteExamScore;

public record DeleteExamScoreCommand(int Id) : IRequestBase;


public class DeleteExamScoreCommandHandler : IRequestBaseHandler<DeleteExamScoreCommand>
{
    private IRepositoryBase<AppDbContext, ExamScore, int> _ExamScoreRepository;

    public DeleteExamScoreCommandHandler(IRepositoryBase<AppDbContext, ExamScore, int> ExamScoreRepository)
    {
        _ExamScoreRepository = ExamScoreRepository;
    }

    public async Task<Unit> Handle(DeleteExamScoreCommand request, CancellationToken cancellationToken)
    {
        await _ExamScoreRepository.DeleteAsync(request.Id,autoSave:true);

        return  Unit.Value;
    }
}
