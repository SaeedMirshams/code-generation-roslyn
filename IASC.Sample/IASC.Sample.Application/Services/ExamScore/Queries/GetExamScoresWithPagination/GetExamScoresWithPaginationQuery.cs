        using AutoMapper;
        using AutoMapper.QueryableExtensions;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Application.DTOs;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.ExamScores.Queries.GetExamScoresWithPagination;

        public record GetExamScoresWithPaginationQuery : IRequestBase<PaginatedList<ExamScoreBriefDto>>
        {

            public int PageNumber { get; init; } = 1;
            public int PageSize { get; init; } = 10;
            //Other Fields
        }

        public class GetExamScoresWithPaginationQueryHandler : IRequestBaseHandler<GetExamScoresWithPaginationQuery, PaginatedList<ExamScoreBriefDto>>
        {
            private IRepositoryBase<AppDbContext, ExamScore,  int > _ExamScoreRepository;
            private readonly IMapper _mapper;

            public GetExamScoresWithPaginationQueryHandler(IRepositoryBase<AppDbContext, ExamScore,  int > ExamScoreRepository, IMapper mapper)
            {
                _ExamScoreRepository = ExamScoreRepository;
                _mapper = mapper;
            }

            public async Task<PaginatedList<ExamScoreBriefDto>> Handle(GetExamScoresWithPaginationQuery request, CancellationToken cancellationToken)
            {

                //var entities = await _ExamScoreRepository.GetPagedListAsync(request.PageNumber-1, request.PageSize);
                //var count = await _ExamScoreRepository.GetCountAsync();
                //List<ExamScoreBriefDto> result =_mapper.Map<List<ExamScore>, List<ExamScoreBriefDto>>(entities);
                //return new PaginatedList<ExamScoreBriefDto>(result, count, request.PageNumber, request.PageSize);
                throw new NotImplementedException();


            }
        }
