using IASC.Core.Entities;
namespace IASC.Sample.Domain.Entities
{
    public class Exam : AuditableEntity<int>
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ExamParameter> ExamParameters { get; set; }
        public virtual ICollection<EvaluationPeriod> EvaluationPeriods { get; set; }

    }
}
