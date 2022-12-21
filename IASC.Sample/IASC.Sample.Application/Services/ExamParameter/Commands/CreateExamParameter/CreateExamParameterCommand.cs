        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;

        namespace IASC.Sample.Application.ExamParameters.Commands.CreateExamParameter;

        public record CreateExamParameterCommand : IRequestBase<ExamParameterDto>
        {
            //Other Properties
        public string Code { get; set; }
        public string Title { get; set; }
        public string Quorum { get; set; }
        public string Description { get; set; }

        }

        public class CreateExamParameterCommandHandler : IRequestBaseHandler<CreateExamParameterCommand, ExamParameterDto>
        {
            private IRepositoryBase<AppDbContext, ExamParameter, int>     _ExamParameterRepository;
            private readonly IMapper _mapper;


            public CreateExamParameterCommandHandler(IRepositoryBase<AppDbContext, ExamParameter, int> ExamParameterRepository, IMapper mapper)
            {
                _ExamParameterRepository = ExamParameterRepository;
                _mapper = mapper;
            }

            public async Task<ExamParameterDto> Handle(CreateExamParameterCommand request, CancellationToken cancellationToken)
            {
                //var entity = new ExamParameter { Code= request.Code,Title=request.Title };
                //var result = await _ExamParameterRepository.InsertAsync(entity, autoSave: true);
                //return _mapper.Map<ExamParameterDto>(result);
                throw new NotImplementedException();
            }
        }
