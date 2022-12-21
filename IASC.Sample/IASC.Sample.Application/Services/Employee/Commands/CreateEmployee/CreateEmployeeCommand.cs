        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;

        namespace IASC.Sample.Application.Employees.Commands.CreateEmployee;

        public record CreateEmployeeCommand : IRequestBase<EmployeeDto>
        {
            //Other Properties
        public string PersonelNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        }

        public class CreateEmployeeCommandHandler : IRequestBaseHandler<CreateEmployeeCommand, EmployeeDto>
        {
            private IRepositoryBase<AppDbContext, Employee, int>     _EmployeeRepository;
            private readonly IMapper _mapper;


            public CreateEmployeeCommandHandler(IRepositoryBase<AppDbContext, Employee, int> EmployeeRepository, IMapper mapper)
            {
                _EmployeeRepository = EmployeeRepository;
                _mapper = mapper;
            }

            public async Task<EmployeeDto> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
            {
                //var entity = new Employee { Code= request.Code,Title=request.Title };
                //var result = await _EmployeeRepository.InsertAsync(entity, autoSave: true);
                //return _mapper.Map<EmployeeDto>(result);
                throw new NotImplementedException();
            }
        }
