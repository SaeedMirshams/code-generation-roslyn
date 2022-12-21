        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;


        namespace IASC.Sample.Application.ExamParameters.Queries.GetExamParametersWithPagination;

        public record GetExamParametersByIdQuery : IRequestBase<ExamParameterDto>
        {

            public int Id { get; init; } 

        }

        public class GetExamParameterByIdQueryHandler : IRequestBaseHandler<GetExamParametersByIdQuery, ExamParameterDto>
        {
            private IRepositoryBase<AppDbContext, ExamParameter,  int > _ExamParameterRepository;
            private readonly IMapper _mapper;

            public GetExamParameterByIdQueryHandler(IRepositoryBase<AppDbContext, ExamParameter, int> ExamParameterRepository, IMapper mapper)
            {
                _ExamParameterRepository = ExamParameterRepository;
                _mapper = mapper;
            }

            public async Task<ExamParameterDto> Handle(GetExamParametersByIdQuery request, CancellationToken cancellationToken)
            {

                var entity = await _ExamParameterRepository.GetAsync(request.Id);
                return _mapper.Map<ExamParameter, ExamParameterDto>(entity);




            }
        }
