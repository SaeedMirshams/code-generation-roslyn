using IASC.Core.Application.MediatR.Interfaces;
using IASC.Core.Repositories;
using IASC.Sample.Domain.Entities;
using IASC.Sample.Infrastructure.Persistence;
using MediatR;

namespace IASC.Sample.Application.CompetencyCategorys.Commands.DeleteCompetencyCategory;

public record DeleteCompetencyCategoryCommand(int Id) : IRequestBase;


public class DeleteCompetencyCategoryCommandHandler : IRequestBaseHandler<DeleteCompetencyCategoryCommand>
{
    private IRepositoryBase<AppDbContext, CompetencyCategory, int> _CompetencyCategoryRepository;

    public DeleteCompetencyCategoryCommandHandler(IRepositoryBase<AppDbContext, CompetencyCategory, int> CompetencyCategoryRepository)
    {
        _CompetencyCategoryRepository = CompetencyCategoryRepository;
    }

    public async Task<Unit> Handle(DeleteCompetencyCategoryCommand request, CancellationToken cancellationToken)
    {
        await _CompetencyCategoryRepository.DeleteAsync(request.Id,autoSave:true);

        return  Unit.Value;
    }
}
