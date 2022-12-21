        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.CompetencyScores.Commands.UpdateCompetencyScore;

        public record UpdateCompetencyScoreCommand : IRequestBase<CompetencyScoreDto>
        {
            public int Id { get; init; }
            //Other Properties
        public double Score { get; set; }

        }

        public class UpdateCompetencyScoreCommandHandler : IRequestBaseHandler<UpdateCompetencyScoreCommand, CompetencyScoreDto>
        {
            private IRepositoryBase<AppDbContext, CompetencyScore, int> _CompetencyScoreRepository;
            private readonly IMapper _mapper;

            public UpdateCompetencyScoreCommandHandler(IRepositoryBase<AppDbContext, CompetencyScore,  int > CompetencyScoreRepository, IMapper mapper)
            {
                _CompetencyScoreRepository = CompetencyScoreRepository;
                _mapper = mapper;
            }

            public async Task<CompetencyScoreDto> Handle(UpdateCompetencyScoreCommand request, CancellationToken cancellationToken)
            {
                //var entity = new CompetencyScore {Id=request.Id, Code = request.Code, Title = request.Title };
                //var result = await _CompetencyScoreRepository.UpdateAsync(entity, autoSave: true);
                //return _mapper.Map<CompetencyScoreDto>(result);
                throw new NotImplementedException();
            }
        }
