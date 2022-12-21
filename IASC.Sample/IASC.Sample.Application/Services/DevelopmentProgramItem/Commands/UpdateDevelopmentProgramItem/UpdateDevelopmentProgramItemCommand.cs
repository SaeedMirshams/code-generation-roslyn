        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.DevelopmentProgramItems.Commands.UpdateDevelopmentProgramItem;

        public record UpdateDevelopmentProgramItemCommand : IRequestBase<DevelopmentProgramItemDto>
        {
            public int Id { get; init; }
            //Other Properties
        public double CurrentScore { get; set; }
        public string Program { get; set; }
        public DateTime DueDate { get; set; }
        public string ExpectedLevel { get; set; }
        public string ExpectedAppearance { get; set; }
        public string EfficiencyValue { get; set; }
        public DateTime ExecutionDate { get; set; }
        public bool IsCompleted { get; set; }
        public string EvaluationMethod { get; set; }
        public DateTime AnnouncementDate { get; set; }
        public string Description { get; set; }

        }

        public class UpdateDevelopmentProgramItemCommandHandler : IRequestBaseHandler<UpdateDevelopmentProgramItemCommand, DevelopmentProgramItemDto>
        {
            private IRepositoryBase<AppDbContext, DevelopmentProgramItem, int> _DevelopmentProgramItemRepository;
            private readonly IMapper _mapper;

            public UpdateDevelopmentProgramItemCommandHandler(IRepositoryBase<AppDbContext, DevelopmentProgramItem,  int > DevelopmentProgramItemRepository, IMapper mapper)
            {
                _DevelopmentProgramItemRepository = DevelopmentProgramItemRepository;
                _mapper = mapper;
            }

            public async Task<DevelopmentProgramItemDto> Handle(UpdateDevelopmentProgramItemCommand request, CancellationToken cancellationToken)
            {
                //var entity = new DevelopmentProgramItem {Id=request.Id, Code = request.Code, Title = request.Title };
                //var result = await _DevelopmentProgramItemRepository.UpdateAsync(entity, autoSave: true);
                //return _mapper.Map<DevelopmentProgramItemDto>(result);
                throw new NotImplementedException();
            }
        }
