using IASC.Core.Application.MediatR.Interfaces;
using IASC.Core.Repositories;
using IASC.Sample.Domain.Entities;
using IASC.Sample.Infrastructure.Persistence;
using MediatR;

namespace IASC.Sample.Application.CompetencyScores.Commands.DeleteCompetencyScore;

public record DeleteCompetencyScoreCommand(int Id) : IRequestBase;


public class DeleteCompetencyScoreCommandHandler : IRequestBaseHandler<DeleteCompetencyScoreCommand>
{
    private IRepositoryBase<AppDbContext, CompetencyScore, int> _CompetencyScoreRepository;

    public DeleteCompetencyScoreCommandHandler(IRepositoryBase<AppDbContext, CompetencyScore, int> CompetencyScoreRepository)
    {
        _CompetencyScoreRepository = CompetencyScoreRepository;
    }

    public async Task<Unit> Handle(DeleteCompetencyScoreCommand request, CancellationToken cancellationToken)
    {
        await _CompetencyScoreRepository.DeleteAsync(request.Id,autoSave:true);

        return  Unit.Value;
    }
}
