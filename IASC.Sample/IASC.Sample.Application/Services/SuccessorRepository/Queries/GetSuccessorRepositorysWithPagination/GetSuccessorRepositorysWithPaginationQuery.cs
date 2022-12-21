        using AutoMapper;
        using AutoMapper.QueryableExtensions;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Application.DTOs;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.SuccessorRepositorys.Queries.GetSuccessorRepositorysWithPagination;

        public record GetSuccessorRepositorysWithPaginationQuery : IRequestBase<PaginatedList<SuccessorRepositoryBriefDto>>
        {

            public int PageNumber { get; init; } = 1;
            public int PageSize { get; init; } = 10;
            //Other Fields
        }

        public class GetSuccessorRepositorysWithPaginationQueryHandler : IRequestBaseHandler<GetSuccessorRepositorysWithPaginationQuery, PaginatedList<SuccessorRepositoryBriefDto>>
        {
            private IRepositoryBase<AppDbContext, SuccessorRepository,  int > _SuccessorRepositoryRepository;
            private readonly IMapper _mapper;

            public GetSuccessorRepositorysWithPaginationQueryHandler(IRepositoryBase<AppDbContext, SuccessorRepository,  int > SuccessorRepositoryRepository, IMapper mapper)
            {
                _SuccessorRepositoryRepository = SuccessorRepositoryRepository;
                _mapper = mapper;
            }

            public async Task<PaginatedList<SuccessorRepositoryBriefDto>> Handle(GetSuccessorRepositorysWithPaginationQuery request, CancellationToken cancellationToken)
            {

                //var entities = await _SuccessorRepositoryRepository.GetPagedListAsync(request.PageNumber-1, request.PageSize);
                //var count = await _SuccessorRepositoryRepository.GetCountAsync();
                //List<SuccessorRepositoryBriefDto> result =_mapper.Map<List<SuccessorRepository>, List<SuccessorRepositoryBriefDto>>(entities);
                //return new PaginatedList<SuccessorRepositoryBriefDto>(result, count, request.PageNumber, request.PageSize);
                throw new NotImplementedException();


            }
        }
