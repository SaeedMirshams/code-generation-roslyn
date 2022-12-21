using IASC.Core.Application.MediatR.Interfaces;
using IASC.Core.Repositories;
using IASC.Sample.Domain.Entities;
using IASC.Sample.Infrastructure.Persistence;
using MediatR;

namespace IASC.Sample.Application.DevelopmentPrograms.Commands.DeleteDevelopmentProgram;

public record DeleteDevelopmentProgramCommand(int Id) : IRequestBase;


public class DeleteDevelopmentProgramCommandHandler : IRequestBaseHandler<DeleteDevelopmentProgramCommand>
{
    private IRepositoryBase<AppDbContext, DevelopmentProgram, int> _DevelopmentProgramRepository;

    public DeleteDevelopmentProgramCommandHandler(IRepositoryBase<AppDbContext, DevelopmentProgram, int> DevelopmentProgramRepository)
    {
        _DevelopmentProgramRepository = DevelopmentProgramRepository;
    }

    public async Task<Unit> Handle(DeleteDevelopmentProgramCommand request, CancellationToken cancellationToken)
    {
        await _DevelopmentProgramRepository.DeleteAsync(request.Id,autoSave:true);

        return  Unit.Value;
    }
}
