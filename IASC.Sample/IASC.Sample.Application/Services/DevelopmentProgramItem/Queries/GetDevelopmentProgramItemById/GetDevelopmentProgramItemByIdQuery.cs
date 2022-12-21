        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;


        namespace IASC.Sample.Application.DevelopmentProgramItems.Queries.GetDevelopmentProgramItemsWithPagination;

        public record GetDevelopmentProgramItemsByIdQuery : IRequestBase<DevelopmentProgramItemDto>
        {

            public int Id { get; init; } 

        }

        public class GetDevelopmentProgramItemByIdQueryHandler : IRequestBaseHandler<GetDevelopmentProgramItemsByIdQuery, DevelopmentProgramItemDto>
        {
            private IRepositoryBase<AppDbContext, DevelopmentProgramItem,  int > _DevelopmentProgramItemRepository;
            private readonly IMapper _mapper;

            public GetDevelopmentProgramItemByIdQueryHandler(IRepositoryBase<AppDbContext, DevelopmentProgramItem, int> DevelopmentProgramItemRepository, IMapper mapper)
            {
                _DevelopmentProgramItemRepository = DevelopmentProgramItemRepository;
                _mapper = mapper;
            }

            public async Task<DevelopmentProgramItemDto> Handle(GetDevelopmentProgramItemsByIdQuery request, CancellationToken cancellationToken)
            {

                var entity = await _DevelopmentProgramItemRepository.GetAsync(request.Id);
                return _mapper.Map<DevelopmentProgramItem, DevelopmentProgramItemDto>(entity);




            }
        }
