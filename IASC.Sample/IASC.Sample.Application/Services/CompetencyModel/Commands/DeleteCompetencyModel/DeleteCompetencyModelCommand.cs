using IASC.Core.Application.MediatR.Interfaces;
using IASC.Core.Repositories;
using IASC.Sample.Domain.Entities;
using IASC.Sample.Infrastructure.Persistence;
using MediatR;

namespace IASC.Sample.Application.CompetencyModels.Commands.DeleteCompetencyModel;

public record DeleteCompetencyModelCommand(int Id) : IRequestBase;


public class DeleteCompetencyModelCommandHandler : IRequestBaseHandler<DeleteCompetencyModelCommand>
{
    private IRepositoryBase<AppDbContext, CompetencyModel, int> _CompetencyModelRepository;

    public DeleteCompetencyModelCommandHandler(IRepositoryBase<AppDbContext, CompetencyModel, int> CompetencyModelRepository)
    {
        _CompetencyModelRepository = CompetencyModelRepository;
    }

    public async Task<Unit> Handle(DeleteCompetencyModelCommand request, CancellationToken cancellationToken)
    {
        await _CompetencyModelRepository.DeleteAsync(request.Id,autoSave:true);

        return  Unit.Value;
    }
}
