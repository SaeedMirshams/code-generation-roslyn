
using IASC.Core.Application.DTOs;
using IASC.Core.Application.Mappings;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Application.DTOs

{
public class DevelopmentProgramItemDto : EntityDto<int>,IMapFrom<DevelopmentProgramItem>
    {
        public double CurrentScore { get; set; }
        public string Program { get; set; }
        public DateTime DueDate { get; set; }
        public string ExpectedLevel { get; set; }
        public string ExpectedAppearance { get; set; }
        public string EfficiencyValue { get; set; }
        public DateTime ExecutionDate { get; set; }
        public bool IsCompleted { get; set; }
        public string EvaluationMethod { get; set; }
        public DateTime AnnouncementDate { get; set; }
        public string Description { get; set; }
    }
}
