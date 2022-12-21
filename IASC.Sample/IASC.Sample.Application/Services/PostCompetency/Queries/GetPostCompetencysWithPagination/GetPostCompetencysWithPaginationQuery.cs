        using AutoMapper;
        using AutoMapper.QueryableExtensions;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Application.DTOs;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.PostCompetencys.Queries.GetPostCompetencysWithPagination;

        public record GetPostCompetencysWithPaginationQuery : IRequestBase<PaginatedList<PostCompetencyBriefDto>>
        {

            public int PageNumber { get; init; } = 1;
            public int PageSize { get; init; } = 10;
            //Other Fields
        }

        public class GetPostCompetencysWithPaginationQueryHandler : IRequestBaseHandler<GetPostCompetencysWithPaginationQuery, PaginatedList<PostCompetencyBriefDto>>
        {
            private IRepositoryBase<AppDbContext, PostCompetency,  int > _PostCompetencyRepository;
            private readonly IMapper _mapper;

            public GetPostCompetencysWithPaginationQueryHandler(IRepositoryBase<AppDbContext, PostCompetency,  int > PostCompetencyRepository, IMapper mapper)
            {
                _PostCompetencyRepository = PostCompetencyRepository;
                _mapper = mapper;
            }

            public async Task<PaginatedList<PostCompetencyBriefDto>> Handle(GetPostCompetencysWithPaginationQuery request, CancellationToken cancellationToken)
            {

                //var entities = await _PostCompetencyRepository.GetPagedListAsync(request.PageNumber-1, request.PageSize);
                //var count = await _PostCompetencyRepository.GetCountAsync();
                //List<PostCompetencyBriefDto> result =_mapper.Map<List<PostCompetency>, List<PostCompetencyBriefDto>>(entities);
                //return new PaginatedList<PostCompetencyBriefDto>(result, count, request.PageNumber, request.PageSize);
                throw new NotImplementedException();


            }
        }
