        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.DevelopmentPrograms.Commands.UpdateDevelopmentProgram;

        public record UpdateDevelopmentProgramCommand : IRequestBase<DevelopmentProgramDto>
        {
            public int Id { get; init; }
            //Other Properties
        public string Goal { get; set; }

        }

        public class UpdateDevelopmentProgramCommandHandler : IRequestBaseHandler<UpdateDevelopmentProgramCommand, DevelopmentProgramDto>
        {
            private IRepositoryBase<AppDbContext, DevelopmentProgram, int> _DevelopmentProgramRepository;
            private readonly IMapper _mapper;

            public UpdateDevelopmentProgramCommandHandler(IRepositoryBase<AppDbContext, DevelopmentProgram,  int > DevelopmentProgramRepository, IMapper mapper)
            {
                _DevelopmentProgramRepository = DevelopmentProgramRepository;
                _mapper = mapper;
            }

            public async Task<DevelopmentProgramDto> Handle(UpdateDevelopmentProgramCommand request, CancellationToken cancellationToken)
            {
                //var entity = new DevelopmentProgram {Id=request.Id, Code = request.Code, Title = request.Title };
                //var result = await _DevelopmentProgramRepository.UpdateAsync(entity, autoSave: true);
                //return _mapper.Map<DevelopmentProgramDto>(result);
                throw new NotImplementedException();
            }
        }
