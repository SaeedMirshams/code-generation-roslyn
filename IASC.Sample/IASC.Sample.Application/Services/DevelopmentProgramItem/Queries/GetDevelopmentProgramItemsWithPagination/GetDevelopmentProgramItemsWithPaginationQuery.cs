        using AutoMapper;
        using AutoMapper.QueryableExtensions;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Application.DTOs;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.DevelopmentProgramItems.Queries.GetDevelopmentProgramItemsWithPagination;

        public record GetDevelopmentProgramItemsWithPaginationQuery : IRequestBase<PaginatedList<DevelopmentProgramItemBriefDto>>
        {

            public int PageNumber { get; init; } = 1;
            public int PageSize { get; init; } = 10;
            //Other Fields
        }

        public class GetDevelopmentProgramItemsWithPaginationQueryHandler : IRequestBaseHandler<GetDevelopmentProgramItemsWithPaginationQuery, PaginatedList<DevelopmentProgramItemBriefDto>>
        {
            private IRepositoryBase<AppDbContext, DevelopmentProgramItem,  int > _DevelopmentProgramItemRepository;
            private readonly IMapper _mapper;

            public GetDevelopmentProgramItemsWithPaginationQueryHandler(IRepositoryBase<AppDbContext, DevelopmentProgramItem,  int > DevelopmentProgramItemRepository, IMapper mapper)
            {
                _DevelopmentProgramItemRepository = DevelopmentProgramItemRepository;
                _mapper = mapper;
            }

            public async Task<PaginatedList<DevelopmentProgramItemBriefDto>> Handle(GetDevelopmentProgramItemsWithPaginationQuery request, CancellationToken cancellationToken)
            {

                //var entities = await _DevelopmentProgramItemRepository.GetPagedListAsync(request.PageNumber-1, request.PageSize);
                //var count = await _DevelopmentProgramItemRepository.GetCountAsync();
                //List<DevelopmentProgramItemBriefDto> result =_mapper.Map<List<DevelopmentProgramItem>, List<DevelopmentProgramItemBriefDto>>(entities);
                //return new PaginatedList<DevelopmentProgramItemBriefDto>(result, count, request.PageNumber, request.PageSize);
                throw new NotImplementedException();


            }
        }
