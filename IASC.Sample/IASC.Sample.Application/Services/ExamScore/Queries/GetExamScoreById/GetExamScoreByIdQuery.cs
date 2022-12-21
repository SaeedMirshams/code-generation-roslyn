        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;


        namespace IASC.Sample.Application.ExamScores.Queries.GetExamScoresWithPagination;

        public record GetExamScoresByIdQuery : IRequestBase<ExamScoreDto>
        {

            public int Id { get; init; } 

        }

        public class GetExamScoreByIdQueryHandler : IRequestBaseHandler<GetExamScoresByIdQuery, ExamScoreDto>
        {
            private IRepositoryBase<AppDbContext, ExamScore,  int > _ExamScoreRepository;
            private readonly IMapper _mapper;

            public GetExamScoreByIdQueryHandler(IRepositoryBase<AppDbContext, ExamScore, int> ExamScoreRepository, IMapper mapper)
            {
                _ExamScoreRepository = ExamScoreRepository;
                _mapper = mapper;
            }

            public async Task<ExamScoreDto> Handle(GetExamScoresByIdQuery request, CancellationToken cancellationToken)
            {

                var entity = await _ExamScoreRepository.GetAsync(request.Id);
                return _mapper.Map<ExamScore, ExamScoreDto>(entity);




            }
        }
