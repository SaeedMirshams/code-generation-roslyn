        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;

        namespace IASC.Sample.Application.CompetencyModels.Commands.CreateCompetencyModel;

        public record CreateCompetencyModelCommand : IRequestBase<CompetencyModelDto>
        {
            //Other Properties
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        }

        public class CreateCompetencyModelCommandHandler : IRequestBaseHandler<CreateCompetencyModelCommand, CompetencyModelDto>
        {
            private IRepositoryBase<AppDbContext, CompetencyModel, int>     _CompetencyModelRepository;
            private readonly IMapper _mapper;


            public CreateCompetencyModelCommandHandler(IRepositoryBase<AppDbContext, CompetencyModel, int> CompetencyModelRepository, IMapper mapper)
            {
                _CompetencyModelRepository = CompetencyModelRepository;
                _mapper = mapper;
            }

            public async Task<CompetencyModelDto> Handle(CreateCompetencyModelCommand request, CancellationToken cancellationToken)
            {
                //var entity = new CompetencyModel { Code= request.Code,Title=request.Title };
                //var result = await _CompetencyModelRepository.InsertAsync(entity, autoSave: true);
                //return _mapper.Map<CompetencyModelDto>(result);
                throw new NotImplementedException();
            }
        }
