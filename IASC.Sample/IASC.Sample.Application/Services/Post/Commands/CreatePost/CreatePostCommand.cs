        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;

        namespace IASC.Sample.Application.Posts.Commands.CreatePost;

        public record CreatePostCommand : IRequestBase<PostDto>
        {
            //Other Properties
        public string Code { get; set; }
        public string Title { get; set; }

        }

        public class CreatePostCommandHandler : IRequestBaseHandler<CreatePostCommand, PostDto>
        {
            private IRepositoryBase<AppDbContext, Post, int>     _PostRepository;
            private readonly IMapper _mapper;


            public CreatePostCommandHandler(IRepositoryBase<AppDbContext, Post, int> PostRepository, IMapper mapper)
            {
                _PostRepository = PostRepository;
                _mapper = mapper;
            }

            public async Task<PostDto> Handle(CreatePostCommand request, CancellationToken cancellationToken)
            {
                //var entity = new Post { Code= request.Code,Title=request.Title };
                //var result = await _PostRepository.InsertAsync(entity, autoSave: true);
                //return _mapper.Map<PostDto>(result);
                throw new NotImplementedException();
            }
        }
