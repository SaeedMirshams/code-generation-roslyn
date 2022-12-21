using IASC.Core.Application.MediatR.Interfaces;
using IASC.Core.Repositories;
using IASC.Sample.Domain.Entities;
using IASC.Sample.Infrastructure.Persistence;
using MediatR;

namespace IASC.Sample.Application.PostCompetencys.Commands.DeletePostCompetency;

public record DeletePostCompetencyCommand(int Id) : IRequestBase;


public class DeletePostCompetencyCommandHandler : IRequestBaseHandler<DeletePostCompetencyCommand>
{
    private IRepositoryBase<AppDbContext, PostCompetency, int> _PostCompetencyRepository;

    public DeletePostCompetencyCommandHandler(IRepositoryBase<AppDbContext, PostCompetency, int> PostCompetencyRepository)
    {
        _PostCompetencyRepository = PostCompetencyRepository;
    }

    public async Task<Unit> Handle(DeletePostCompetencyCommand request, CancellationToken cancellationToken)
    {
        await _PostCompetencyRepository.DeleteAsync(request.Id,autoSave:true);

        return  Unit.Value;
    }
}
