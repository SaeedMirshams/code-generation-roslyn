using IASC.Core.Entities;
namespace IASC.Sample.Domain.Entities
{
    public class EvaluationResult : Entity<int>
    {
        public double IQScore { get; set; }
        public DateTime ExecutionDate { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int EvaluationPeriodId { get; set; }
        public EvaluationPeriod EvaluationPeriod { get; set; }
        public virtual ICollection<ExamScore> ExamScores { get; set; }
        public virtual ICollection<CompetencyScore> CompetencyScores { get; set; }

    }
}
