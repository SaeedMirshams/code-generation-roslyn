        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.CompetencyModels.Commands.UpdateCompetencyModel;

        public record UpdateCompetencyModelCommand : IRequestBase<CompetencyModelDto>
        {
            public int Id { get; init; }
            //Other Properties
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        }

        public class UpdateCompetencyModelCommandHandler : IRequestBaseHandler<UpdateCompetencyModelCommand, CompetencyModelDto>
        {
            private IRepositoryBase<AppDbContext, CompetencyModel, int> _CompetencyModelRepository;
            private readonly IMapper _mapper;

            public UpdateCompetencyModelCommandHandler(IRepositoryBase<AppDbContext, CompetencyModel,  int > CompetencyModelRepository, IMapper mapper)
            {
                _CompetencyModelRepository = CompetencyModelRepository;
                _mapper = mapper;
            }

            public async Task<CompetencyModelDto> Handle(UpdateCompetencyModelCommand request, CancellationToken cancellationToken)
            {
                //var entity = new CompetencyModel {Id=request.Id, Code = request.Code, Title = request.Title };
                //var result = await _CompetencyModelRepository.UpdateAsync(entity, autoSave: true);
                //return _mapper.Map<CompetencyModelDto>(result);
                throw new NotImplementedException();
            }
        }
