        using AutoMapper;
        using AutoMapper.QueryableExtensions;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Application.DTOs;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.Exams.Queries.GetExamsWithPagination;

        public record GetExamsWithPaginationQuery : IRequestBase<PaginatedList<ExamBriefDto>>
        {

            public int PageNumber { get; init; } = 1;
            public int PageSize { get; init; } = 10;
            //Other Fields
        }

        public class GetExamsWithPaginationQueryHandler : IRequestBaseHandler<GetExamsWithPaginationQuery, PaginatedList<ExamBriefDto>>
        {
            private IRepositoryBase<AppDbContext, Exam,  int > _ExamRepository;
            private readonly IMapper _mapper;

            public GetExamsWithPaginationQueryHandler(IRepositoryBase<AppDbContext, Exam,  int > ExamRepository, IMapper mapper)
            {
                _ExamRepository = ExamRepository;
                _mapper = mapper;
            }

            public async Task<PaginatedList<ExamBriefDto>> Handle(GetExamsWithPaginationQuery request, CancellationToken cancellationToken)
            {

                //var entities = await _ExamRepository.GetPagedListAsync(request.PageNumber-1, request.PageSize);
                //var count = await _ExamRepository.GetCountAsync();
                //List<ExamBriefDto> result =_mapper.Map<List<Exam>, List<ExamBriefDto>>(entities);
                //return new PaginatedList<ExamBriefDto>(result, count, request.PageNumber, request.PageSize);
                throw new NotImplementedException();


            }
        }
