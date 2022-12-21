using IASC.Core.Application.MediatR.Interfaces;
using IASC.Core.Repositories;
using IASC.Sample.Domain.Entities;
using IASC.Sample.Infrastructure.Persistence;
using MediatR;

namespace IASC.Sample.Application.Posts.Commands.DeletePost;

public record DeletePostCommand(int Id) : IRequestBase;


public class DeletePostCommandHandler : IRequestBaseHandler<DeletePostCommand>
{
    private IRepositoryBase<AppDbContext, Post, int> _PostRepository;

    public DeletePostCommandHandler(IRepositoryBase<AppDbContext, Post, int> PostRepository)
    {
        _PostRepository = PostRepository;
    }

    public async Task<Unit> Handle(DeletePostCommand request, CancellationToken cancellationToken)
    {
        await _PostRepository.DeleteAsync(request.Id,autoSave:true);

        return  Unit.Value;
    }
}
