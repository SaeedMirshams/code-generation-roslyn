        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;


        namespace IASC.Sample.Application.EvaluationPeriods.Queries.GetEvaluationPeriodsWithPagination;

        public record GetEvaluationPeriodsByIdQuery : IRequestBase<EvaluationPeriodDto>
        {

            public int Id { get; init; } 

        }

        public class GetEvaluationPeriodByIdQueryHandler : IRequestBaseHandler<GetEvaluationPeriodsByIdQuery, EvaluationPeriodDto>
        {
            private IRepositoryBase<AppDbContext, EvaluationPeriod,  int > _EvaluationPeriodRepository;
            private readonly IMapper _mapper;

            public GetEvaluationPeriodByIdQueryHandler(IRepositoryBase<AppDbContext, EvaluationPeriod, int> EvaluationPeriodRepository, IMapper mapper)
            {
                _EvaluationPeriodRepository = EvaluationPeriodRepository;
                _mapper = mapper;
            }

            public async Task<EvaluationPeriodDto> Handle(GetEvaluationPeriodsByIdQuery request, CancellationToken cancellationToken)
            {

                var entity = await _EvaluationPeriodRepository.GetAsync(request.Id);
                return _mapper.Map<EvaluationPeriod, EvaluationPeriodDto>(entity);




            }
        }
