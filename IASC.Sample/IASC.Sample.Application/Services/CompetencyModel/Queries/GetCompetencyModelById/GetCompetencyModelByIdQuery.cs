        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;


        namespace IASC.Sample.Application.CompetencyModels.Queries.GetCompetencyModelsWithPagination;

        public record GetCompetencyModelsByIdQuery : IRequestBase<CompetencyModelDto>
        {

            public int Id { get; init; } 

        }

        public class GetCompetencyModelByIdQueryHandler : IRequestBaseHandler<GetCompetencyModelsByIdQuery, CompetencyModelDto>
        {
            private IRepositoryBase<AppDbContext, CompetencyModel,  int > _CompetencyModelRepository;
            private readonly IMapper _mapper;

            public GetCompetencyModelByIdQueryHandler(IRepositoryBase<AppDbContext, CompetencyModel, int> CompetencyModelRepository, IMapper mapper)
            {
                _CompetencyModelRepository = CompetencyModelRepository;
                _mapper = mapper;
            }

            public async Task<CompetencyModelDto> Handle(GetCompetencyModelsByIdQuery request, CancellationToken cancellationToken)
            {

                var entity = await _CompetencyModelRepository.GetAsync(request.Id);
                return _mapper.Map<CompetencyModel, CompetencyModelDto>(entity);




            }
        }
