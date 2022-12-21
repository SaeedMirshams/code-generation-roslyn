        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;


        namespace IASC.Sample.Application.DevelopmentPrograms.Queries.GetDevelopmentProgramsWithPagination;

        public record GetDevelopmentProgramsByIdQuery : IRequestBase<DevelopmentProgramDto>
        {

            public int Id { get; init; } 

        }

        public class GetDevelopmentProgramByIdQueryHandler : IRequestBaseHandler<GetDevelopmentProgramsByIdQuery, DevelopmentProgramDto>
        {
            private IRepositoryBase<AppDbContext, DevelopmentProgram,  int > _DevelopmentProgramRepository;
            private readonly IMapper _mapper;

            public GetDevelopmentProgramByIdQueryHandler(IRepositoryBase<AppDbContext, DevelopmentProgram, int> DevelopmentProgramRepository, IMapper mapper)
            {
                _DevelopmentProgramRepository = DevelopmentProgramRepository;
                _mapper = mapper;
            }

            public async Task<DevelopmentProgramDto> Handle(GetDevelopmentProgramsByIdQuery request, CancellationToken cancellationToken)
            {

                var entity = await _DevelopmentProgramRepository.GetAsync(request.Id);
                return _mapper.Map<DevelopmentProgram, DevelopmentProgramDto>(entity);




            }
        }
