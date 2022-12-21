        using AutoMapper;
        using AutoMapper.QueryableExtensions;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Application.DTOs;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.CompetencyCategorys.Queries.GetCompetencyCategorysWithPagination;

        public record GetCompetencyCategorysWithPaginationQuery : IRequestBase<PaginatedList<CompetencyCategoryBriefDto>>
        {

            public int PageNumber { get; init; } = 1;
            public int PageSize { get; init; } = 10;
            //Other Fields
        }

        public class GetCompetencyCategorysWithPaginationQueryHandler : IRequestBaseHandler<GetCompetencyCategorysWithPaginationQuery, PaginatedList<CompetencyCategoryBriefDto>>
        {
            private IRepositoryBase<AppDbContext, CompetencyCategory,  int > _CompetencyCategoryRepository;
            private readonly IMapper _mapper;

            public GetCompetencyCategorysWithPaginationQueryHandler(IRepositoryBase<AppDbContext, CompetencyCategory,  int > CompetencyCategoryRepository, IMapper mapper)
            {
                _CompetencyCategoryRepository = CompetencyCategoryRepository;
                _mapper = mapper;
            }

            public async Task<PaginatedList<CompetencyCategoryBriefDto>> Handle(GetCompetencyCategorysWithPaginationQuery request, CancellationToken cancellationToken)
            {

                //var entities = await _CompetencyCategoryRepository.GetPagedListAsync(request.PageNumber-1, request.PageSize);
                //var count = await _CompetencyCategoryRepository.GetCountAsync();
                //List<CompetencyCategoryBriefDto> result =_mapper.Map<List<CompetencyCategory>, List<CompetencyCategoryBriefDto>>(entities);
                //return new PaginatedList<CompetencyCategoryBriefDto>(result, count, request.PageNumber, request.PageSize);
                throw new NotImplementedException();


            }
        }
