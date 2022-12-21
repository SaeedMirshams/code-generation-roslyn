        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;

        namespace IASC.Sample.Application.PostCompetencys.Commands.CreatePostCompetency;

        public record CreatePostCompetencyCommand : IRequestBase<PostCompetencyDto>
        {
            //Other Properties
        public string Quorum { get; set; }
        public double Weight { get; set; }

        }

        public class CreatePostCompetencyCommandHandler : IRequestBaseHandler<CreatePostCompetencyCommand, PostCompetencyDto>
        {
            private IRepositoryBase<AppDbContext, PostCompetency, int>     _PostCompetencyRepository;
            private readonly IMapper _mapper;


            public CreatePostCompetencyCommandHandler(IRepositoryBase<AppDbContext, PostCompetency, int> PostCompetencyRepository, IMapper mapper)
            {
                _PostCompetencyRepository = PostCompetencyRepository;
                _mapper = mapper;
            }

            public async Task<PostCompetencyDto> Handle(CreatePostCompetencyCommand request, CancellationToken cancellationToken)
            {
                //var entity = new PostCompetency { Code= request.Code,Title=request.Title };
                //var result = await _PostCompetencyRepository.InsertAsync(entity, autoSave: true);
                //return _mapper.Map<PostCompetencyDto>(result);
                throw new NotImplementedException();
            }
        }
