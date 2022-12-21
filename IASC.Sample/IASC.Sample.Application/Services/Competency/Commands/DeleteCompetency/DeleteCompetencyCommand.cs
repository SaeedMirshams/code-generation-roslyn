using IASC.Core.Application.MediatR.Interfaces;
using IASC.Core.Repositories;
using IASC.Sample.Domain.Entities;
using IASC.Sample.Infrastructure.Persistence;
using MediatR;

namespace IASC.Sample.Application.Competencys.Commands.DeleteCompetency;

public record DeleteCompetencyCommand(int Id) : IRequestBase;


public class DeleteCompetencyCommandHandler : IRequestBaseHandler<DeleteCompetencyCommand>
{
    private IRepositoryBase<AppDbContext, Competency, int> _CompetencyRepository;

    public DeleteCompetencyCommandHandler(IRepositoryBase<AppDbContext, Competency, int> CompetencyRepository)
    {
        _CompetencyRepository = CompetencyRepository;
    }

    public async Task<Unit> Handle(DeleteCompetencyCommand request, CancellationToken cancellationToken)
    {
        await _CompetencyRepository.DeleteAsync(request.Id,autoSave:true);

        return  Unit.Value;
    }
}
