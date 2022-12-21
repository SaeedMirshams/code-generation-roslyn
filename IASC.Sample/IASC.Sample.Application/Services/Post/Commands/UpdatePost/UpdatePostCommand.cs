        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.Posts.Commands.UpdatePost;

        public record UpdatePostCommand : IRequestBase<PostDto>
        {
            public int Id { get; init; }
            //Other Properties
        public string Code { get; set; }
        public string Title { get; set; }

        }

        public class UpdatePostCommandHandler : IRequestBaseHandler<UpdatePostCommand, PostDto>
        {
            private IRepositoryBase<AppDbContext, Post, int> _PostRepository;
            private readonly IMapper _mapper;

            public UpdatePostCommandHandler(IRepositoryBase<AppDbContext, Post,  int > PostRepository, IMapper mapper)
            {
                _PostRepository = PostRepository;
                _mapper = mapper;
            }

            public async Task<PostDto> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
            {
                //var entity = new Post {Id=request.Id, Code = request.Code, Title = request.Title };
                //var result = await _PostRepository.UpdateAsync(entity, autoSave: true);
                //return _mapper.Map<PostDto>(result);
                throw new NotImplementedException();
            }
        }
