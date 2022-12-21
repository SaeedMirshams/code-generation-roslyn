        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;


        namespace IASC.Sample.Application.SuccessorRepositorys.Queries.GetSuccessorRepositorysWithPagination;

        public record GetSuccessorRepositorysByIdQuery : IRequestBase<SuccessorRepositoryDto>
        {

            public int Id { get; init; } 

        }

        public class GetSuccessorRepositoryByIdQueryHandler : IRequestBaseHandler<GetSuccessorRepositorysByIdQuery, SuccessorRepositoryDto>
        {
            private IRepositoryBase<AppDbContext, SuccessorRepository,  int > _SuccessorRepositoryRepository;
            private readonly IMapper _mapper;

            public GetSuccessorRepositoryByIdQueryHandler(IRepositoryBase<AppDbContext, SuccessorRepository, int> SuccessorRepositoryRepository, IMapper mapper)
            {
                _SuccessorRepositoryRepository = SuccessorRepositoryRepository;
                _mapper = mapper;
            }

            public async Task<SuccessorRepositoryDto> Handle(GetSuccessorRepositorysByIdQuery request, CancellationToken cancellationToken)
            {

                var entity = await _SuccessorRepositoryRepository.GetAsync(request.Id);
                return _mapper.Map<SuccessorRepository, SuccessorRepositoryDto>(entity);




            }
        }
