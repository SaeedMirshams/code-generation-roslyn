        using AutoMapper;
        using IASC.Core.Application.MediatR.Interfaces;
        using IASC.Core.Repositories;
        using IASC.Sample.Application.DTOs;
        using IASC.Sample.Domain.Entities;
        using IASC.Sample.Infrastructure.Persistence;
        using MediatR;

        namespace IASC.Sample.Application.Employees.Commands.UpdateEmployee;

        public record UpdateEmployeeCommand : IRequestBase<EmployeeDto>
        {
            public int Id { get; init; }
            //Other Properties
        public string PersonelNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        }

        public class UpdateEmployeeCommandHandler : IRequestBaseHandler<UpdateEmployeeCommand, EmployeeDto>
        {
            private IRepositoryBase<AppDbContext, Employee, int> _EmployeeRepository;
            private readonly IMapper _mapper;

            public UpdateEmployeeCommandHandler(IRepositoryBase<AppDbContext, Employee,  int > EmployeeRepository, IMapper mapper)
            {
                _EmployeeRepository = EmployeeRepository;
                _mapper = mapper;
            }

            public async Task<EmployeeDto> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
            {
                //var entity = new Employee {Id=request.Id, Code = request.Code, Title = request.Title };
                //var result = await _EmployeeRepository.UpdateAsync(entity, autoSave: true);
                //return _mapper.Map<EmployeeDto>(result);
                throw new NotImplementedException();
            }
        }
