
using IASC.Core.Application.DTOs;
using IASC.Core.Application.Mappings;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Application.DTOs

{
public class EvaluationResultDto : EntityDto<int>,IMapFrom<EvaluationResult>
    {
        public double IQScore { get; set; }
        public DateTime ExecutionDate { get; set; }
    }
}
