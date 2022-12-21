
using IASC.Core.Application.DTOs;
using IASC.Core.Application.Mappings;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Application.DTOs

{
public class EvaluationPeriodDto : EntityDto<int>,IMapFrom<EvaluationPeriod>
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
