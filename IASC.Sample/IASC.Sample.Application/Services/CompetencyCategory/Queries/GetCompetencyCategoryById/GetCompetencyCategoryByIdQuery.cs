        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;


        namespace IASC.Sample.Application.CompetencyCategorys.Queries.GetCompetencyCategorysWithPagination;

        public record GetCompetencyCategorysByIdQuery : IRequestBase<CompetencyCategoryDto>
        {

            public int Id { get; init; } 

        }

        public class GetCompetencyCategoryByIdQueryHandler : IRequestBaseHandler<GetCompetencyCategorysByIdQuery, CompetencyCategoryDto>
        {
            private IRepositoryBase<AppDbContext, CompetencyCategory,  int > _CompetencyCategoryRepository;
            private readonly IMapper _mapper;

            public GetCompetencyCategoryByIdQueryHandler(IRepositoryBase<AppDbContext, CompetencyCategory, int> CompetencyCategoryRepository, IMapper mapper)
            {
                _CompetencyCategoryRepository = CompetencyCategoryRepository;
                _mapper = mapper;
            }

            public async Task<CompetencyCategoryDto> Handle(GetCompetencyCategorysByIdQuery request, CancellationToken cancellationToken)
            {

                var entity = await _CompetencyCategoryRepository.GetAsync(request.Id);
                return _mapper.Map<CompetencyCategory, CompetencyCategoryDto>(entity);




            }
        }
