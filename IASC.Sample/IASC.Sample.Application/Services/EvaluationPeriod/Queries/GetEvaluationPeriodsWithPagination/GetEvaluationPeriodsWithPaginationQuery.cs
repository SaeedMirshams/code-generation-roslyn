        using AutoMapper;
        using AutoMapper.QueryableExtensions;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Application.DTOs;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.EvaluationPeriods.Queries.GetEvaluationPeriodsWithPagination;

        public record GetEvaluationPeriodsWithPaginationQuery : IRequestBase<PaginatedList<EvaluationPeriodBriefDto>>
        {

            public int PageNumber { get; init; } = 1;
            public int PageSize { get; init; } = 10;
            //Other Fields
        }

        public class GetEvaluationPeriodsWithPaginationQueryHandler : IRequestBaseHandler<GetEvaluationPeriodsWithPaginationQuery, PaginatedList<EvaluationPeriodBriefDto>>
        {
            private IRepositoryBase<AppDbContext, EvaluationPeriod,  int > _EvaluationPeriodRepository;
            private readonly IMapper _mapper;

            public GetEvaluationPeriodsWithPaginationQueryHandler(IRepositoryBase<AppDbContext, EvaluationPeriod,  int > EvaluationPeriodRepository, IMapper mapper)
            {
                _EvaluationPeriodRepository = EvaluationPeriodRepository;
                _mapper = mapper;
            }

            public async Task<PaginatedList<EvaluationPeriodBriefDto>> Handle(GetEvaluationPeriodsWithPaginationQuery request, CancellationToken cancellationToken)
            {

                //var entities = await _EvaluationPeriodRepository.GetPagedListAsync(request.PageNumber-1, request.PageSize);
                //var count = await _EvaluationPeriodRepository.GetCountAsync();
                //List<EvaluationPeriodBriefDto> result =_mapper.Map<List<EvaluationPeriod>, List<EvaluationPeriodBriefDto>>(entities);
                //return new PaginatedList<EvaluationPeriodBriefDto>(result, count, request.PageNumber, request.PageSize);
                throw new NotImplementedException();


            }
        }
