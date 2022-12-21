        using AutoMapper;
        using AutoMapper.QueryableExtensions;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Application.DTOs;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.ExamParameters.Queries.GetExamParametersWithPagination;

        public record GetExamParametersWithPaginationQuery : IRequestBase<PaginatedList<ExamParameterBriefDto>>
        {

            public int PageNumber { get; init; } = 1;
            public int PageSize { get; init; } = 10;
            //Other Fields
        }

        public class GetExamParametersWithPaginationQueryHandler : IRequestBaseHandler<GetExamParametersWithPaginationQuery, PaginatedList<ExamParameterBriefDto>>
        {
            private IRepositoryBase<AppDbContext, ExamParameter,  int > _ExamParameterRepository;
            private readonly IMapper _mapper;

            public GetExamParametersWithPaginationQueryHandler(IRepositoryBase<AppDbContext, ExamParameter,  int > ExamParameterRepository, IMapper mapper)
            {
                _ExamParameterRepository = ExamParameterRepository;
                _mapper = mapper;
            }

            public async Task<PaginatedList<ExamParameterBriefDto>> Handle(GetExamParametersWithPaginationQuery request, CancellationToken cancellationToken)
            {

                //var entities = await _ExamParameterRepository.GetPagedListAsync(request.PageNumber-1, request.PageSize);
                //var count = await _ExamParameterRepository.GetCountAsync();
                //List<ExamParameterBriefDto> result =_mapper.Map<List<ExamParameter>, List<ExamParameterBriefDto>>(entities);
                //return new PaginatedList<ExamParameterBriefDto>(result, count, request.PageNumber, request.PageSize);
                throw new NotImplementedException();


            }
        }
