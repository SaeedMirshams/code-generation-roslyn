using IASC.Core.Application.MediatR.Interfaces;
using IASC.Core.Repositories;
using IASC.Sample.Domain.Entities;
using IASC.Sample.Infrastructure.Persistence;
using MediatR;

namespace IASC.Sample.Application.SuccessorRepositorys.Commands.DeleteSuccessorRepository;

public record DeleteSuccessorRepositoryCommand(int Id) : IRequestBase;


public class DeleteSuccessorRepositoryCommandHandler : IRequestBaseHandler<DeleteSuccessorRepositoryCommand>
{
    private IRepositoryBase<AppDbContext, SuccessorRepository, int> _SuccessorRepositoryRepository;

    public DeleteSuccessorRepositoryCommandHandler(IRepositoryBase<AppDbContext, SuccessorRepository, int> SuccessorRepositoryRepository)
    {
        _SuccessorRepositoryRepository = SuccessorRepositoryRepository;
    }

    public async Task<Unit> Handle(DeleteSuccessorRepositoryCommand request, CancellationToken cancellationToken)
    {
        await _SuccessorRepositoryRepository.DeleteAsync(request.Id,autoSave:true);

        return  Unit.Value;
    }
}
