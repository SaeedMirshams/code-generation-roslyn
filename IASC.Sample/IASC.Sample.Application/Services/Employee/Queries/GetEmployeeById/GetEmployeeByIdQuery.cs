        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;


        namespace IASC.Sample.Application.Employees.Queries.GetEmployeesWithPagination;

        public record GetEmployeesByIdQuery : IRequestBase<EmployeeDto>
        {

            public int Id { get; init; } 

        }

        public class GetEmployeeByIdQueryHandler : IRequestBaseHandler<GetEmployeesByIdQuery, EmployeeDto>
        {
            private IRepositoryBase<AppDbContext, Employee,  int > _EmployeeRepository;
            private readonly IMapper _mapper;

            public GetEmployeeByIdQueryHandler(IRepositoryBase<AppDbContext, Employee, int> EmployeeRepository, IMapper mapper)
            {
                _EmployeeRepository = EmployeeRepository;
                _mapper = mapper;
            }

            public async Task<EmployeeDto> Handle(GetEmployeesByIdQuery request, CancellationToken cancellationToken)
            {

                var entity = await _EmployeeRepository.GetAsync(request.Id);
                return _mapper.Map<Employee, EmployeeDto>(entity);




            }
        }
