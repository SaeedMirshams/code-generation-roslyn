        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.EvaluationPeriods.Commands.UpdateEvaluationPeriod;

        public record UpdateEvaluationPeriodCommand : IRequestBase<EvaluationPeriodDto>
        {
            public int Id { get; init; }
            //Other Properties
        public string Code { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        }

        public class UpdateEvaluationPeriodCommandHandler : IRequestBaseHandler<UpdateEvaluationPeriodCommand, EvaluationPeriodDto>
        {
            private IRepositoryBase<AppDbContext, EvaluationPeriod, int> _EvaluationPeriodRepository;
            private readonly IMapper _mapper;

            public UpdateEvaluationPeriodCommandHandler(IRepositoryBase<AppDbContext, EvaluationPeriod,  int > EvaluationPeriodRepository, IMapper mapper)
            {
                _EvaluationPeriodRepository = EvaluationPeriodRepository;
                _mapper = mapper;
            }

            public async Task<EvaluationPeriodDto> Handle(UpdateEvaluationPeriodCommand request, CancellationToken cancellationToken)
            {
                //var entity = new EvaluationPeriod {Id=request.Id, Code = request.Code, Title = request.Title };
                //var result = await _EvaluationPeriodRepository.UpdateAsync(entity, autoSave: true);
                //return _mapper.Map<EvaluationPeriodDto>(result);
                throw new NotImplementedException();
            }
        }
