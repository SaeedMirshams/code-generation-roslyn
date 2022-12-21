        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.SuccessorRepositorys.Commands.UpdateSuccessorRepository;

        public record UpdateSuccessorRepositoryCommand : IRequestBase<SuccessorRepositoryDto>
        {
            public int Id { get; init; }
            //Other Properties
        public int Order { get; set; }

        }

        public class UpdateSuccessorRepositoryCommandHandler : IRequestBaseHandler<UpdateSuccessorRepositoryCommand, SuccessorRepositoryDto>
        {
            private IRepositoryBase<AppDbContext, SuccessorRepository, int> _SuccessorRepositoryRepository;
            private readonly IMapper _mapper;

            public UpdateSuccessorRepositoryCommandHandler(IRepositoryBase<AppDbContext, SuccessorRepository,  int > SuccessorRepositoryRepository, IMapper mapper)
            {
                _SuccessorRepositoryRepository = SuccessorRepositoryRepository;
                _mapper = mapper;
            }

            public async Task<SuccessorRepositoryDto> Handle(UpdateSuccessorRepositoryCommand request, CancellationToken cancellationToken)
            {
                //var entity = new SuccessorRepository {Id=request.Id, Code = request.Code, Title = request.Title };
                //var result = await _SuccessorRepositoryRepository.UpdateAsync(entity, autoSave: true);
                //return _mapper.Map<SuccessorRepositoryDto>(result);
                throw new NotImplementedException();
            }
        }
