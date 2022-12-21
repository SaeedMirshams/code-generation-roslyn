        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.ExamParameters.Commands.UpdateExamParameter;

        public record UpdateExamParameterCommand : IRequestBase<ExamParameterDto>
        {
            public int Id { get; init; }
            //Other Properties
        public string Code { get; set; }
        public string Title { get; set; }
        public string Quorum { get; set; }
        public string Description { get; set; }

        }

        public class UpdateExamParameterCommandHandler : IRequestBaseHandler<UpdateExamParameterCommand, ExamParameterDto>
        {
            private IRepositoryBase<AppDbContext, ExamParameter, int> _ExamParameterRepository;
            private readonly IMapper _mapper;

            public UpdateExamParameterCommandHandler(IRepositoryBase<AppDbContext, ExamParameter,  int > ExamParameterRepository, IMapper mapper)
            {
                _ExamParameterRepository = ExamParameterRepository;
                _mapper = mapper;
            }

            public async Task<ExamParameterDto> Handle(UpdateExamParameterCommand request, CancellationToken cancellationToken)
            {
                //var entity = new ExamParameter {Id=request.Id, Code = request.Code, Title = request.Title };
                //var result = await _ExamParameterRepository.UpdateAsync(entity, autoSave: true);
                //return _mapper.Map<ExamParameterDto>(result);
                throw new NotImplementedException();
            }
        }
