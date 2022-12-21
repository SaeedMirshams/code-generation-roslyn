        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.Exams.Commands.UpdateExam;

        public record UpdateExamCommand : IRequestBase<ExamDto>
        {
            public int Id { get; init; }
            //Other Properties
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        }

        public class UpdateExamCommandHandler : IRequestBaseHandler<UpdateExamCommand, ExamDto>
        {
            private IRepositoryBase<AppDbContext, Exam, int> _ExamRepository;
            private readonly IMapper _mapper;

            public UpdateExamCommandHandler(IRepositoryBase<AppDbContext, Exam,  int > ExamRepository, IMapper mapper)
            {
                _ExamRepository = ExamRepository;
                _mapper = mapper;
            }

            public async Task<ExamDto> Handle(UpdateExamCommand request, CancellationToken cancellationToken)
            {
                //var entity = new Exam {Id=request.Id, Code = request.Code, Title = request.Title };
                //var result = await _ExamRepository.UpdateAsync(entity, autoSave: true);
                //return _mapper.Map<ExamDto>(result);
                throw new NotImplementedException();
            }
        }
