using IASC.Core.Entities;
namespace IASC.Sample.Domain.Entities
{
    public class ExamScore : Entity<int>
    {
        public double Score { get; set; }
        public int EvaluationResultId { get; set; }
        public EvaluationResult EvaluationResult { get; set; }
        public int ExamParameterId { get; set; }
        public ExamParameter ExamParameter { get; set; }

    }
}
