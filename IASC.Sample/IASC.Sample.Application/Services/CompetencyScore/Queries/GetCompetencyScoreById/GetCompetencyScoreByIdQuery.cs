        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;


        namespace IASC.Sample.Application.CompetencyScores.Queries.GetCompetencyScoresWithPagination;

        public record GetCompetencyScoresByIdQuery : IRequestBase<CompetencyScoreDto>
        {

            public int Id { get; init; } 

        }

        public class GetCompetencyScoreByIdQueryHandler : IRequestBaseHandler<GetCompetencyScoresByIdQuery, CompetencyScoreDto>
        {
            private IRepositoryBase<AppDbContext, CompetencyScore,  int > _CompetencyScoreRepository;
            private readonly IMapper _mapper;

            public GetCompetencyScoreByIdQueryHandler(IRepositoryBase<AppDbContext, CompetencyScore, int> CompetencyScoreRepository, IMapper mapper)
            {
                _CompetencyScoreRepository = CompetencyScoreRepository;
                _mapper = mapper;
            }

            public async Task<CompetencyScoreDto> Handle(GetCompetencyScoresByIdQuery request, CancellationToken cancellationToken)
            {

                var entity = await _CompetencyScoreRepository.GetAsync(request.Id);
                return _mapper.Map<CompetencyScore, CompetencyScoreDto>(entity);




            }
        }
