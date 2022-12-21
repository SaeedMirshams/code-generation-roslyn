
using IASC.Core.Application.DTOs;
using IASC.Core.Application.Mappings;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Application.DTOs;

public class EmployeeBriefDto : EntityDto<int>,IMapFrom<Employee>
    {
        public string PersonelNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
