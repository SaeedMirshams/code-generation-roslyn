        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;

        namespace IASC.Sample.Application.ExamScores.Commands.CreateExamScore;

        public record CreateExamScoreCommand : IRequestBase<ExamScoreDto>
        {
            //Other Properties
        public double Score { get; set; }

        }

        public class CreateExamScoreCommandHandler : IRequestBaseHandler<CreateExamScoreCommand, ExamScoreDto>
        {
            private IRepositoryBase<AppDbContext, ExamScore, int>     _ExamScoreRepository;
            private readonly IMapper _mapper;


            public CreateExamScoreCommandHandler(IRepositoryBase<AppDbContext, ExamScore, int> ExamScoreRepository, IMapper mapper)
            {
                _ExamScoreRepository = ExamScoreRepository;
                _mapper = mapper;
            }

            public async Task<ExamScoreDto> Handle(CreateExamScoreCommand request, CancellationToken cancellationToken)
            {
                //var entity = new ExamScore { Code= request.Code,Title=request.Title };
                //var result = await _ExamScoreRepository.InsertAsync(entity, autoSave: true);
                //return _mapper.Map<ExamScoreDto>(result);
                throw new NotImplementedException();
            }
        }
