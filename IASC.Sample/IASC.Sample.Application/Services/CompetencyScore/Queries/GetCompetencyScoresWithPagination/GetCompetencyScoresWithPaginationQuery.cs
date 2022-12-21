        using AutoMapper;
        using AutoMapper.QueryableExtensions;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Application.DTOs;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.CompetencyScores.Queries.GetCompetencyScoresWithPagination;

        public record GetCompetencyScoresWithPaginationQuery : IRequestBase<PaginatedList<CompetencyScoreBriefDto>>
        {

            public int PageNumber { get; init; } = 1;
            public int PageSize { get; init; } = 10;
            //Other Fields
        }

        public class GetCompetencyScoresWithPaginationQueryHandler : IRequestBaseHandler<GetCompetencyScoresWithPaginationQuery, PaginatedList<CompetencyScoreBriefDto>>
        {
            private IRepositoryBase<AppDbContext, CompetencyScore,  int > _CompetencyScoreRepository;
            private readonly IMapper _mapper;

            public GetCompetencyScoresWithPaginationQueryHandler(IRepositoryBase<AppDbContext, CompetencyScore,  int > CompetencyScoreRepository, IMapper mapper)
            {
                _CompetencyScoreRepository = CompetencyScoreRepository;
                _mapper = mapper;
            }

            public async Task<PaginatedList<CompetencyScoreBriefDto>> Handle(GetCompetencyScoresWithPaginationQuery request, CancellationToken cancellationToken)
            {

                //var entities = await _CompetencyScoreRepository.GetPagedListAsync(request.PageNumber-1, request.PageSize);
                //var count = await _CompetencyScoreRepository.GetCountAsync();
                //List<CompetencyScoreBriefDto> result =_mapper.Map<List<CompetencyScore>, List<CompetencyScoreBriefDto>>(entities);
                //return new PaginatedList<CompetencyScoreBriefDto>(result, count, request.PageNumber, request.PageSize);
                throw new NotImplementedException();


            }
        }
