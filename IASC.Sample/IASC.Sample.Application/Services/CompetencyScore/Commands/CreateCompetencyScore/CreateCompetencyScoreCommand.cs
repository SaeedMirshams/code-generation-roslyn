        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;

        namespace IASC.Sample.Application.CompetencyScores.Commands.CreateCompetencyScore;

        public record CreateCompetencyScoreCommand : IRequestBase<CompetencyScoreDto>
        {
            //Other Properties
        public double Score { get; set; }

        }

        public class CreateCompetencyScoreCommandHandler : IRequestBaseHandler<CreateCompetencyScoreCommand, CompetencyScoreDto>
        {
            private IRepositoryBase<AppDbContext, CompetencyScore, int>     _CompetencyScoreRepository;
            private readonly IMapper _mapper;


            public CreateCompetencyScoreCommandHandler(IRepositoryBase<AppDbContext, CompetencyScore, int> CompetencyScoreRepository, IMapper mapper)
            {
                _CompetencyScoreRepository = CompetencyScoreRepository;
                _mapper = mapper;
            }

            public async Task<CompetencyScoreDto> Handle(CreateCompetencyScoreCommand request, CancellationToken cancellationToken)
            {
                //var entity = new CompetencyScore { Code= request.Code,Title=request.Title };
                //var result = await _CompetencyScoreRepository.InsertAsync(entity, autoSave: true);
                //return _mapper.Map<CompetencyScoreDto>(result);
                throw new NotImplementedException();
            }
        }
