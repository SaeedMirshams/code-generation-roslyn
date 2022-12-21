        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.Competencys.Commands.UpdateCompetency;

        public record UpdateCompetencyCommand : IRequestBase<CompetencyDto>
        {
            public int Id { get; init; }
            //Other Properties
        public string Name { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        }

        public class UpdateCompetencyCommandHandler : IRequestBaseHandler<UpdateCompetencyCommand, CompetencyDto>
        {
            private IRepositoryBase<AppDbContext, Competency, int> _CompetencyRepository;
            private readonly IMapper _mapper;

            public UpdateCompetencyCommandHandler(IRepositoryBase<AppDbContext, Competency,  int > CompetencyRepository, IMapper mapper)
            {
                _CompetencyRepository = CompetencyRepository;
                _mapper = mapper;
            }

            public async Task<CompetencyDto> Handle(UpdateCompetencyCommand request, CancellationToken cancellationToken)
            {
                //var entity = new Competency {Id=request.Id, Code = request.Code, Title = request.Title };
                //var result = await _CompetencyRepository.UpdateAsync(entity, autoSave: true);
                //return _mapper.Map<CompetencyDto>(result);
                throw new NotImplementedException();
            }
        }
