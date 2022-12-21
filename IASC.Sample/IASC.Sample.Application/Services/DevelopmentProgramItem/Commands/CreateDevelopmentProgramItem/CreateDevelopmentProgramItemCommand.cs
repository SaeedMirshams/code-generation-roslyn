        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;

        namespace IASC.Sample.Application.DevelopmentProgramItems.Commands.CreateDevelopmentProgramItem;

        public record CreateDevelopmentProgramItemCommand : IRequestBase<DevelopmentProgramItemDto>
        {
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

        public class CreateDevelopmentProgramItemCommandHandler : IRequestBaseHandler<CreateDevelopmentProgramItemCommand, DevelopmentProgramItemDto>
        {
            private IRepositoryBase<AppDbContext, DevelopmentProgramItem, int>     _DevelopmentProgramItemRepository;
            private readonly IMapper _mapper;


            public CreateDevelopmentProgramItemCommandHandler(IRepositoryBase<AppDbContext, DevelopmentProgramItem, int> DevelopmentProgramItemRepository, IMapper mapper)
            {
                _DevelopmentProgramItemRepository = DevelopmentProgramItemRepository;
                _mapper = mapper;
            }

            public async Task<DevelopmentProgramItemDto> Handle(CreateDevelopmentProgramItemCommand request, CancellationToken cancellationToken)
            {
                //var entity = new DevelopmentProgramItem { Code= request.Code,Title=request.Title };
                //var result = await _DevelopmentProgramItemRepository.InsertAsync(entity, autoSave: true);
                //return _mapper.Map<DevelopmentProgramItemDto>(result);
                throw new NotImplementedException();
            }
        }
