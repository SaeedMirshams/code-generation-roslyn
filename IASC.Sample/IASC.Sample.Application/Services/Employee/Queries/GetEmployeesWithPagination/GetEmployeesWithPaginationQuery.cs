        using AutoMapper;
        using AutoMapper.QueryableExtensions;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Application.DTOs;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.Employees.Queries.GetEmployeesWithPagination;

        public record GetEmployeesWithPaginationQuery : IRequestBase<PaginatedList<EmployeeBriefDto>>
        {

            public int PageNumber { get; init; } = 1;
            public int PageSize { get; init; } = 10;
            //Other Fields
        }

        public class GetEmployeesWithPaginationQueryHandler : IRequestBaseHandler<GetEmployeesWithPaginationQuery, PaginatedList<EmployeeBriefDto>>
        {
            private IRepositoryBase<AppDbContext, Employee,  int > _EmployeeRepository;
            private readonly IMapper _mapper;

            public GetEmployeesWithPaginationQueryHandler(IRepositoryBase<AppDbContext, Employee,  int > EmployeeRepository, IMapper mapper)
            {
                _EmployeeRepository = EmployeeRepository;
                _mapper = mapper;
            }

            public async Task<PaginatedList<EmployeeBriefDto>> Handle(GetEmployeesWithPaginationQuery request, CancellationToken cancellationToken)
            {

                //var entities = await _EmployeeRepository.GetPagedListAsync(request.PageNumber-1, request.PageSize);
                //var count = await _EmployeeRepository.GetCountAsync();
                //List<EmployeeBriefDto> result =_mapper.Map<List<Employee>, List<EmployeeBriefDto>>(entities);
                //return new PaginatedList<EmployeeBriefDto>(result, count, request.PageNumber, request.PageSize);
                throw new NotImplementedException();


            }
        }
