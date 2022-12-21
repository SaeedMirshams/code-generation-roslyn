        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;


        namespace IASC.Sample.Application.Exams.Queries.GetExamsWithPagination;

        public record GetExamsByIdQuery : IRequestBase<ExamDto>
        {

            public int Id { get; init; } 

        }

        public class GetExamByIdQueryHandler : IRequestBaseHandler<GetExamsByIdQuery, ExamDto>
        {
            private IRepositoryBase<AppDbContext, Exam,  int > _ExamRepository;
            private readonly IMapper _mapper;

            public GetExamByIdQueryHandler(IRepositoryBase<AppDbContext, Exam, int> ExamRepository, IMapper mapper)
            {
                _ExamRepository = ExamRepository;
                _mapper = mapper;
            }

            public async Task<ExamDto> Handle(GetExamsByIdQuery request, CancellationToken cancellationToken)
            {

                var entity = await _ExamRepository.GetAsync(request.Id);
                return _mapper.Map<Exam, ExamDto>(entity);




            }
        }
