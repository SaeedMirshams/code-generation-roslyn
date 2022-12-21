using IASC.Core.Application.MediatR.Interfaces;
using IASC.Core.Repositories;
using IASC.Sample.Domain.Entities;
using IASC.Sample.Infrastructure.Persistence;
using MediatR;

namespace IASC.Sample.Application.DevelopmentProgramItems.Commands.DeleteDevelopmentProgramItem;

public record DeleteDevelopmentProgramItemCommand(int Id) : IRequestBase;


public class DeleteDevelopmentProgramItemCommandHandler : IRequestBaseHandler<DeleteDevelopmentProgramItemCommand>
{
    private IRepositoryBase<AppDbContext, DevelopmentProgramItem, int> _DevelopmentProgramItemRepository;

    public DeleteDevelopmentProgramItemCommandHandler(IRepositoryBase<AppDbContext, DevelopmentProgramItem, int> DevelopmentProgramItemRepository)
    {
        _DevelopmentProgramItemRepository = DevelopmentProgramItemRepository;
    }

    public async Task<Unit> Handle(DeleteDevelopmentProgramItemCommand request, CancellationToken cancellationToken)
    {
        await _DevelopmentProgramItemRepository.DeleteAsync(request.Id,autoSave:true);

        return  Unit.Value;
    }
}
