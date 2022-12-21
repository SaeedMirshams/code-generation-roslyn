using IASC.Core.Entities;
namespace IASC.Sample.Domain.Entities
{
    public class DevelopmentProgramItem : AuditableEntity<int>
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
        public int DevelopmentProgramId { get; set; }
        public DevelopmentProgram DevelopmentProgram { get; set; }
        public int CompetencyId { get; set; }
        public Competency Competency { get; set; }

    }
}
