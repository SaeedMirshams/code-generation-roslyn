        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.ExamScores.Commands.UpdateExamScore;

        public record UpdateExamScoreCommand : IRequestBase<ExamScoreDto>
        {
            public int Id { get; init; }
            //Other Properties
        public double Score { get; set; }

        }

        public class UpdateExamScoreCommandHandler : IRequestBaseHandler<UpdateExamScoreCommand, ExamScoreDto>
        {
            private IRepositoryBase<AppDbContext, ExamScore, int> _ExamScoreRepository;
            private readonly IMapper _mapper;

            public UpdateExamScoreCommandHandler(IRepositoryBase<AppDbContext, ExamScore,  int > ExamScoreRepository, IMapper mapper)
            {
                _ExamScoreRepository = ExamScoreRepository;
                _mapper = mapper;
            }

            public async Task<ExamScoreDto> Handle(UpdateExamScoreCommand request, CancellationToken cancellationToken)
            {
                //var entity = new ExamScore {Id=request.Id, Code = request.Code, Title = request.Title };
                //var result = await _ExamScoreRepository.UpdateAsync(entity, autoSave: true);
                //return _mapper.Map<ExamScoreDto>(result);
                throw new NotImplementedException();
            }
        }
