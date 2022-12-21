        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;


        namespace IASC.Sample.Application.EvaluationResults.Queries.GetEvaluationResultsWithPagination;

        public record GetEvaluationResultsByIdQuery : IRequestBase<EvaluationResultDto>
        {

            public int Id { get; init; } 

        }

        public class GetEvaluationResultByIdQueryHandler : IRequestBaseHandler<GetEvaluationResultsByIdQuery, EvaluationResultDto>
        {
            private IRepositoryBase<AppDbContext, EvaluationResult,  int > _EvaluationResultRepository;
            private readonly IMapper _mapper;

            public GetEvaluationResultByIdQueryHandler(IRepositoryBase<AppDbContext, EvaluationResult, int> EvaluationResultRepository, IMapper mapper)
            {
                _EvaluationResultRepository = EvaluationResultRepository;
                _mapper = mapper;
            }

            public async Task<EvaluationResultDto> Handle(GetEvaluationResultsByIdQuery request, CancellationToken cancellationToken)
            {

                var entity = await _EvaluationResultRepository.GetAsync(request.Id);
                return _mapper.Map<EvaluationResult, EvaluationResultDto>(entity);




            }
        }
