        using AutoMapper;
        using AutoMapper.QueryableExtensions;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Application.DTOs;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.Competencys.Queries.GetCompetencysWithPagination;

        public record GetCompetencysWithPaginationQuery : IRequestBase<PaginatedList<CompetencyBriefDto>>
        {

            public int PageNumber { get; init; } = 1;
            public int PageSize { get; init; } = 10;
            //Other Fields
        }

        public class GetCompetencysWithPaginationQueryHandler : IRequestBaseHandler<GetCompetencysWithPaginationQuery, PaginatedList<CompetencyBriefDto>>
        {
            private IRepositoryBase<AppDbContext, Competency,  int > _CompetencyRepository;
            private readonly IMapper _mapper;

            public GetCompetencysWithPaginationQueryHandler(IRepositoryBase<AppDbContext, Competency,  int > CompetencyRepository, IMapper mapper)
            {
                _CompetencyRepository = CompetencyRepository;
                _mapper = mapper;
            }

            public async Task<PaginatedList<CompetencyBriefDto>> Handle(GetCompetencysWithPaginationQuery request, CancellationToken cancellationToken)
            {

                //var entities = await _CompetencyRepository.GetPagedListAsync(request.PageNumber-1, request.PageSize);
                //var count = await _CompetencyRepository.GetCountAsync();
                //List<CompetencyBriefDto> result =_mapper.Map<List<Competency>, List<CompetencyBriefDto>>(entities);
                //return new PaginatedList<CompetencyBriefDto>(result, count, request.PageNumber, request.PageSize);
                throw new NotImplementedException();


            }
        }
