        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;

        namespace IASC.Sample.Application.Competencys.Commands.CreateCompetency;

        public record CreateCompetencyCommand : IRequestBase<CompetencyDto>
        {
            //Other Properties
        public string Name { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        }

        public class CreateCompetencyCommandHandler : IRequestBaseHandler<CreateCompetencyCommand, CompetencyDto>
        {
            private IRepositoryBase<AppDbContext, Competency, int>     _CompetencyRepository;
            private readonly IMapper _mapper;


            public CreateCompetencyCommandHandler(IRepositoryBase<AppDbContext, Competency, int> CompetencyRepository, IMapper mapper)
            {
                _CompetencyRepository = CompetencyRepository;
                _mapper = mapper;
            }

            public async Task<CompetencyDto> Handle(CreateCompetencyCommand request, CancellationToken cancellationToken)
            {
                //var entity = new Competency { Code= request.Code,Title=request.Title };
                //var result = await _CompetencyRepository.InsertAsync(entity, autoSave: true);
                //return _mapper.Map<CompetencyDto>(result);
                throw new NotImplementedException();
            }
        }
