        using AutoMapper;
        using AutoMapper.QueryableExtensions;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Application.DTOs;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.EvaluationResults.Queries.GetEvaluationResultsWithPagination;

        public record GetEvaluationResultsWithPaginationQuery : IRequestBase<PaginatedList<EvaluationResultBriefDto>>
        {

            public int PageNumber { get; init; } = 1;
            public int PageSize { get; init; } = 10;
            //Other Fields
        }

        public class GetEvaluationResultsWithPaginationQueryHandler : IRequestBaseHandler<GetEvaluationResultsWithPaginationQuery, PaginatedList<EvaluationResultBriefDto>>
        {
            private IRepositoryBase<AppDbContext, EvaluationResult,  int > _EvaluationResultRepository;
            private readonly IMapper _mapper;

            public GetEvaluationResultsWithPaginationQueryHandler(IRepositoryBase<AppDbContext, EvaluationResult,  int > EvaluationResultRepository, IMapper mapper)
            {
                _EvaluationResultRepository = EvaluationResultRepository;
                _mapper = mapper;
            }

            public async Task<PaginatedList<EvaluationResultBriefDto>> Handle(GetEvaluationResultsWithPaginationQuery request, CancellationToken cancellationToken)
            {

                //var entities = await _EvaluationResultRepository.GetPagedListAsync(request.PageNumber-1, request.PageSize);
                //var count = await _EvaluationResultRepository.GetCountAsync();
                //List<EvaluationResultBriefDto> result =_mapper.Map<List<EvaluationResult>, List<EvaluationResultBriefDto>>(entities);
                //return new PaginatedList<EvaluationResultBriefDto>(result, count, request.PageNumber, request.PageSize);
                throw new NotImplementedException();


            }
        }
