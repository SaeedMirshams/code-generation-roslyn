        using AutoMapper;
        using AutoMapper.QueryableExtensions;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Application.DTOs;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.Posts.Queries.GetPostsWithPagination;

        public record GetPostsWithPaginationQuery : IRequestBase<PaginatedList<PostBriefDto>>
        {

            public int PageNumber { get; init; } = 1;
            public int PageSize { get; init; } = 10;
            //Other Fields
        }

        public class GetPostsWithPaginationQueryHandler : IRequestBaseHandler<GetPostsWithPaginationQuery, PaginatedList<PostBriefDto>>
        {
            private IRepositoryBase<AppDbContext, Post,  int > _PostRepository;
            private readonly IMapper _mapper;

            public GetPostsWithPaginationQueryHandler(IRepositoryBase<AppDbContext, Post,  int > PostRepository, IMapper mapper)
            {
                _PostRepository = PostRepository;
                _mapper = mapper;
            }

            public async Task<PaginatedList<PostBriefDto>> Handle(GetPostsWithPaginationQuery request, CancellationToken cancellationToken)
            {

                //var entities = await _PostRepository.GetPagedListAsync(request.PageNumber-1, request.PageSize);
                //var count = await _PostRepository.GetCountAsync();
                //List<PostBriefDto> result =_mapper.Map<List<Post>, List<PostBriefDto>>(entities);
                //return new PaginatedList<PostBriefDto>(result, count, request.PageNumber, request.PageSize);
                throw new NotImplementedException();


            }
        }
