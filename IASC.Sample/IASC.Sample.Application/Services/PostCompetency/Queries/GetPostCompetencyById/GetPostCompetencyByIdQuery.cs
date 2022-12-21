        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;


        namespace IASC.Sample.Application.PostCompetencys.Queries.GetPostCompetencysWithPagination;

        public record GetPostCompetencysByIdQuery : IRequestBase<PostCompetencyDto>
        {

            public int Id { get; init; } 

        }

        public class GetPostCompetencyByIdQueryHandler : IRequestBaseHandler<GetPostCompetencysByIdQuery, PostCompetencyDto>
        {
            private IRepositoryBase<AppDbContext, PostCompetency,  int > _PostCompetencyRepository;
            private readonly IMapper _mapper;

            public GetPostCompetencyByIdQueryHandler(IRepositoryBase<AppDbContext, PostCompetency, int> PostCompetencyRepository, IMapper mapper)
            {
                _PostCompetencyRepository = PostCompetencyRepository;
                _mapper = mapper;
            }

            public async Task<PostCompetencyDto> Handle(GetPostCompetencysByIdQuery request, CancellationToken cancellationToken)
            {

                var entity = await _PostCompetencyRepository.GetAsync(request.Id);
                return _mapper.Map<PostCompetency, PostCompetencyDto>(entity);




            }
        }
