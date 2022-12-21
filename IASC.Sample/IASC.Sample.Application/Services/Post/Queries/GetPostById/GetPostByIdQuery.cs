        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;


        namespace IASC.Sample.Application.Posts.Queries.GetPostsWithPagination;

        public record GetPostsByIdQuery : IRequestBase<PostDto>
        {

            public int Id { get; init; } 

        }

        public class GetPostByIdQueryHandler : IRequestBaseHandler<GetPostsByIdQuery, PostDto>
        {
            private IRepositoryBase<AppDbContext, Post,  int > _PostRepository;
            private readonly IMapper _mapper;

            public GetPostByIdQueryHandler(IRepositoryBase<AppDbContext, Post, int> PostRepository, IMapper mapper)
            {
                _PostRepository = PostRepository;
                _mapper = mapper;
            }

            public async Task<PostDto> Handle(GetPostsByIdQuery request, CancellationToken cancellationToken)
            {

                var entity = await _PostRepository.GetAsync(request.Id);
                return _mapper.Map<Post, PostDto>(entity);




            }
        }
