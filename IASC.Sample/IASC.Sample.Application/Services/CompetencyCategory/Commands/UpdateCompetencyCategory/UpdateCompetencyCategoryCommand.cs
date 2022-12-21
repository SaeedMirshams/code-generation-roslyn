        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.CompetencyCategorys.Commands.UpdateCompetencyCategory;

        public record UpdateCompetencyCategoryCommand : IRequestBase<CompetencyCategoryDto>
        {
            public int Id { get; init; }
            //Other Properties
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        }

        public class UpdateCompetencyCategoryCommandHandler : IRequestBaseHandler<UpdateCompetencyCategoryCommand, CompetencyCategoryDto>
        {
            private IRepositoryBase<AppDbContext, CompetencyCategory, int> _CompetencyCategoryRepository;
            private readonly IMapper _mapper;

            public UpdateCompetencyCategoryCommandHandler(IRepositoryBase<AppDbContext, CompetencyCategory,  int > CompetencyCategoryRepository, IMapper mapper)
            {
                _CompetencyCategoryRepository = CompetencyCategoryRepository;
                _mapper = mapper;
            }

            public async Task<CompetencyCategoryDto> Handle(UpdateCompetencyCategoryCommand request, CancellationToken cancellationToken)
            {
                //var entity = new CompetencyCategory {Id=request.Id, Code = request.Code, Title = request.Title };
                //var result = await _CompetencyCategoryRepository.UpdateAsync(entity, autoSave: true);
                //return _mapper.Map<CompetencyCategoryDto>(result);
                throw new NotImplementedException();
            }
        }
