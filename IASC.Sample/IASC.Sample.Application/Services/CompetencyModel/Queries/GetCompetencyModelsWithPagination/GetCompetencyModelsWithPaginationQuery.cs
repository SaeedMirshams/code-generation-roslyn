        using AutoMapper;
        using AutoMapper.QueryableExtensions;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Application.DTOs;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.CompetencyModels.Queries.GetCompetencyModelsWithPagination;

        public record GetCompetencyModelsWithPaginationQuery : IRequestBase<PaginatedList<CompetencyModelBriefDto>>
        {

            public int PageNumber { get; init; } = 1;
            public int PageSize { get; init; } = 10;
            //Other Fields
        }

        public class GetCompetencyModelsWithPaginationQueryHandler : IRequestBaseHandler<GetCompetencyModelsWithPaginationQuery, PaginatedList<CompetencyModelBriefDto>>
        {
            private IRepositoryBase<AppDbContext, CompetencyModel,  int > _CompetencyModelRepository;
            private readonly IMapper _mapper;

            public GetCompetencyModelsWithPaginationQueryHandler(IRepositoryBase<AppDbContext, CompetencyModel,  int > CompetencyModelRepository, IMapper mapper)
            {
                _CompetencyModelRepository = CompetencyModelRepository;
                _mapper = mapper;
            }

            public async Task<PaginatedList<CompetencyModelBriefDto>> Handle(GetCompetencyModelsWithPaginationQuery request, CancellationToken cancellationToken)
            {

                //var entities = await _CompetencyModelRepository.GetPagedListAsync(request.PageNumber-1, request.PageSize);
                //var count = await _CompetencyModelRepository.GetCountAsync();
                //List<CompetencyModelBriefDto> result =_mapper.Map<List<CompetencyModel>, List<CompetencyModelBriefDto>>(entities);
                //return new PaginatedList<CompetencyModelBriefDto>(result, count, request.PageNumber, request.PageSize);
                throw new NotImplementedException();


            }
        }
