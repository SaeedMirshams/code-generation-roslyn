        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.PostCompetencys.Commands.UpdatePostCompetency;

        public record UpdatePostCompetencyCommand : IRequestBase<PostCompetencyDto>
        {
            public int Id { get; init; }
            //Other Properties
        public string Quorum { get; set; }
        public double Weight { get; set; }

        }

        public class UpdatePostCompetencyCommandHandler : IRequestBaseHandler<UpdatePostCompetencyCommand, PostCompetencyDto>
        {
            private IRepositoryBase<AppDbContext, PostCompetency, int> _PostCompetencyRepository;
            private readonly IMapper _mapper;

            public UpdatePostCompetencyCommandHandler(IRepositoryBase<AppDbContext, PostCompetency,  int > PostCompetencyRepository, IMapper mapper)
            {
                _PostCompetencyRepository = PostCompetencyRepository;
                _mapper = mapper;
            }

            public async Task<PostCompetencyDto> Handle(UpdatePostCompetencyCommand request, CancellationToken cancellationToken)
            {
                //var entity = new PostCompetency {Id=request.Id, Code = request.Code, Title = request.Title };
                //var result = await _PostCompetencyRepository.UpdateAsync(entity, autoSave: true);
                //return _mapper.Map<PostCompetencyDto>(result);
                throw new NotImplementedException();
            }
        }
