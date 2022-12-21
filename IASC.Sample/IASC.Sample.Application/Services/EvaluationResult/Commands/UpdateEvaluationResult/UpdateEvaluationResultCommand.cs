        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.EvaluationResults.Commands.UpdateEvaluationResult;

        public record UpdateEvaluationResultCommand : IRequestBase<EvaluationResultDto>
        {
            public int Id { get; init; }
            //Other Properties
        public double IQScore { get; set; }
        public DateTime ExecutionDate { get; set; }

        }

        public class UpdateEvaluationResultCommandHandler : IRequestBaseHandler<UpdateEvaluationResultCommand, EvaluationResultDto>
        {
            private IRepositoryBase<AppDbContext, EvaluationResult, int> _EvaluationResultRepository;
            private readonly IMapper _mapper;

            public UpdateEvaluationResultCommandHandler(IRepositoryBase<AppDbContext, EvaluationResult,  int > EvaluationResultRepository, IMapper mapper)
            {
                _EvaluationResultRepository = EvaluationResultRepository;
                _mapper = mapper;
            }

            public async Task<EvaluationResultDto> Handle(UpdateEvaluationResultCommand request, CancellationToken cancellationToken)
            {
                //var entity = new EvaluationResult {Id=request.Id, Code = request.Code, Title = request.Title };
                //var result = await _EvaluationResultRepository.UpdateAsync(entity, autoSave: true);
                //return _mapper.Map<EvaluationResultDto>(result);
                throw new NotImplementedException();
            }
        }
