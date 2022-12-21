        using AutoMapper;
        using AutoMapper.QueryableExtensions;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Application.DTOs;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.DevelopmentPrograms.Queries.GetDevelopmentProgramsWithPagination;

        public record GetDevelopmentProgramsWithPaginationQuery : IRequestBase<PaginatedList<DevelopmentProgramBriefDto>>
        {

            public int PageNumber { get; init; } = 1;
            public int PageSize { get; init; } = 10;
            //Other Fields
        }

        public class GetDevelopmentProgramsWithPaginationQueryHandler : IRequestBaseHandler<GetDevelopmentProgramsWithPaginationQuery, PaginatedList<DevelopmentProgramBriefDto>>
        {
            private IRepositoryBase<AppDbContext, DevelopmentProgram,  int > _DevelopmentProgramRepository;
            private readonly IMapper _mapper;

            public GetDevelopmentProgramsWithPaginationQueryHandler(IRepositoryBase<AppDbContext, DevelopmentProgram,  int > DevelopmentProgramRepository, IMapper mapper)
            {
                _DevelopmentProgramRepository = DevelopmentProgramRepository;
                _mapper = mapper;
            }

            public async Task<PaginatedList<DevelopmentProgramBriefDto>> Handle(GetDevelopmentProgramsWithPaginationQuery request, CancellationToken cancellationToken)
            {

                //var entities = await _DevelopmentProgramRepository.GetPagedListAsync(request.PageNumber-1, request.PageSize);
                //var count = await _DevelopmentProgramRepository.GetCountAsync();
                //List<DevelopmentProgramBriefDto> result =_mapper.Map<List<DevelopmentProgram>, List<DevelopmentProgramBriefDto>>(entities);
                //return new PaginatedList<DevelopmentProgramBriefDto>(result, count, request.PageNumber, request.PageSize);
                throw new NotImplementedException();


            }
        }
