        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;

        namespace IASC.Sample.Application.CompetencyCategorys.Commands.CreateCompetencyCategory;

        public record CreateCompetencyCategoryCommand : IRequestBase<CompetencyCategoryDto>
        {
            //Other Properties
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        }

        public class CreateCompetencyCategoryCommandHandler : IRequestBaseHandler<CreateCompetencyCategoryCommand, CompetencyCategoryDto>
        {
            private IRepositoryBase<AppDbContext, CompetencyCategory, int>     _CompetencyCategoryRepository;
            private readonly IMapper _mapper;


            public CreateCompetencyCategoryCommandHandler(IRepositoryBase<AppDbContext, CompetencyCategory, int> CompetencyCategoryRepository, IMapper mapper)
            {
                _CompetencyCategoryRepository = CompetencyCategoryRepository;
                _mapper = mapper;
            }

            public async Task<CompetencyCategoryDto> Handle(CreateCompetencyCategoryCommand request, CancellationToken cancellationToken)
            {
                //var entity = new CompetencyCategory { Code= request.Code,Title=request.Title };
                //var result = await _CompetencyCategoryRepository.InsertAsync(entity, autoSave: true);
                //return _mapper.Map<CompetencyCategoryDto>(result);
                throw new NotImplementedException();
            }
        }
