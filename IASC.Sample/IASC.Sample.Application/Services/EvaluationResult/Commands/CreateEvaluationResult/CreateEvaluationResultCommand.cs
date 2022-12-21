        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;

        namespace IASC.Sample.Application.EvaluationResults.Commands.CreateEvaluationResult;

        public record CreateEvaluationResultCommand : IRequestBase<EvaluationResultDto>
        {
            //Other Properties
        public double IQScore { get; set; }
        public DateTime ExecutionDate { get; set; }

        }

        public class CreateEvaluationResultCommandHandler : IRequestBaseHandler<CreateEvaluationResultCommand, EvaluationResultDto>
        {
            private IRepositoryBase<AppDbContext, EvaluationResult, int>     _EvaluationResultRepository;
            private readonly IMapper _mapper;


            public CreateEvaluationResultCommandHandler(IRepositoryBase<AppDbContext, EvaluationResult, int> EvaluationResultRepository, IMapper mapper)
            {
                _EvaluationResultRepository = EvaluationResultRepository;
                _mapper = mapper;
            }

            public async Task<EvaluationResultDto> Handle(CreateEvaluationResultCommand request, CancellationToken cancellationToken)
            {
                //var entity = new EvaluationResult { Code= request.Code,Title=request.Title };
                //var result = await _EvaluationResultRepository.InsertAsync(entity, autoSave: true);
                //return _mapper.Map<EvaluationResultDto>(result);
                throw new NotImplementedException();
            }
        }
