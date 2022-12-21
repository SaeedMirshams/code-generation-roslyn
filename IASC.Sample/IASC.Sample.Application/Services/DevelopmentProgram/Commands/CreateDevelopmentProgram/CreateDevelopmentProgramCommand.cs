        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;

        namespace IASC.Sample.Application.DevelopmentPrograms.Commands.CreateDevelopmentProgram;

        public record CreateDevelopmentProgramCommand : IRequestBase<DevelopmentProgramDto>
        {
            //Other Properties
        public string Goal { get; set; }

        }

        public class CreateDevelopmentProgramCommandHandler : IRequestBaseHandler<CreateDevelopmentProgramCommand, DevelopmentProgramDto>
        {
            private IRepositoryBase<AppDbContext, DevelopmentProgram, int>     _DevelopmentProgramRepository;
            private readonly IMapper _mapper;


            public CreateDevelopmentProgramCommandHandler(IRepositoryBase<AppDbContext, DevelopmentProgram, int> DevelopmentProgramRepository, IMapper mapper)
            {
                _DevelopmentProgramRepository = DevelopmentProgramRepository;
                _mapper = mapper;
            }

            public async Task<DevelopmentProgramDto> Handle(CreateDevelopmentProgramCommand request, CancellationToken cancellationToken)
            {
                //var entity = new DevelopmentProgram { Code= request.Code,Title=request.Title };
                //var result = await _DevelopmentProgramRepository.InsertAsync(entity, autoSave: true);
                //return _mapper.Map<DevelopmentProgramDto>(result);
                throw new NotImplementedException();
            }
        }
