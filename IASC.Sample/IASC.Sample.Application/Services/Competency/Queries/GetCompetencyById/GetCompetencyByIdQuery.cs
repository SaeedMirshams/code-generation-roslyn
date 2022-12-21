        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;


        namespace IASC.Sample.Application.Competencys.Queries.GetCompetencysWithPagination;

        public record GetCompetencysByIdQuery : IRequestBase<CompetencyDto>
        {

            public int Id { get; init; } 

        }

        public class GetCompetencyByIdQueryHandler : IRequestBaseHandler<GetCompetencysByIdQuery, CompetencyDto>
        {
            private IRepositoryBase<AppDbContext, Competency,  int > _CompetencyRepository;
            private readonly IMapper _mapper;

            public GetCompetencyByIdQueryHandler(IRepositoryBase<AppDbContext, Competency, int> CompetencyRepository, IMapper mapper)
            {
                _CompetencyRepository = CompetencyRepository;
                _mapper = mapper;
            }

            public async Task<CompetencyDto> Handle(GetCompetencysByIdQuery request, CancellationToken cancellationToken)
            {

                var entity = await _CompetencyRepository.GetAsync(request.Id);
                return _mapper.Map<Competency, CompetencyDto>(entity);




            }
        }
