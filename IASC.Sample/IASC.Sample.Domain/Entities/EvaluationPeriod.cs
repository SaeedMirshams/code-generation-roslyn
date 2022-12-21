using IASC.Core.Entities;
namespace IASC.Sample.Domain.Entities
{
    public class EvaluationPeriod : AuditableEntity<int>
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public int CompetencyModelId { get; set; }
        public CompetencyModel CompetencyModel { get; set; }
        public virtual ICollection<EvaluationResult> EvaluationResults { get; set; }

    }
}
