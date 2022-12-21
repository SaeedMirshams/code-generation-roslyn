        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;

        namespace IASC.Sample.Application.SuccessorRepositorys.Commands.CreateSuccessorRepository;

        public record CreateSuccessorRepositoryCommand : IRequestBase<SuccessorRepositoryDto>
        {
            //Other Properties
        public int Order { get; set; }

        }

        public class CreateSuccessorRepositoryCommandHandler : IRequestBaseHandler<CreateSuccessorRepositoryCommand, SuccessorRepositoryDto>
        {
            private IRepositoryBase<AppDbContext, SuccessorRepository, int>     _SuccessorRepositoryRepository;
            private readonly IMapper _mapper;


            public CreateSuccessorRepositoryCommandHandler(IRepositoryBase<AppDbContext, SuccessorRepository, int> SuccessorRepositoryRepository, IMapper mapper)
            {
                _SuccessorRepositoryRepository = SuccessorRepositoryRepository;
                _mapper = mapper;
            }

            public async Task<SuccessorRepositoryDto> Handle(CreateSuccessorRepositoryCommand request, CancellationToken cancellationToken)
            {
                //var entity = new SuccessorRepository { Code= request.Code,Title=request.Title };
                //var result = await _SuccessorRepositoryRepository.InsertAsync(entity, autoSave: true);
                //return _mapper.Map<SuccessorRepositoryDto>(result);
                throw new NotImplementedException();
            }
        }
