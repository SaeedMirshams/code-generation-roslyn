        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;

        namespace IASC.Sample.Application.Exams.Commands.CreateExam;

        public record CreateExamCommand : IRequestBase<ExamDto>
        {
            //Other Properties
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        }

        public class CreateExamCommandHandler : IRequestBaseHandler<CreateExamCommand, ExamDto>
        {
            private IRepositoryBase<AppDbContext, Exam, int>     _ExamRepository;
            private readonly IMapper _mapper;


            public CreateExamCommandHandler(IRepositoryBase<AppDbContext, Exam, int> ExamRepository, IMapper mapper)
            {
                _ExamRepository = ExamRepository;
                _mapper = mapper;
            }

            public async Task<ExamDto> Handle(CreateExamCommand request, CancellationToken cancellationToken)
            {
                //var entity = new Exam { Code= request.Code,Title=request.Title };
                //var result = await _ExamRepository.InsertAsync(entity, autoSave: true);
                //return _mapper.Map<ExamDto>(result);
                throw new NotImplementedException();
            }
        }
