using IASC.Core.Entities;
namespace IASC.Sample.Domain.Entities
{
    public class CompetencyScore : Entity<int>
    {
        public double Score { get; set; }
        public int EvaluationResultId { get; set; }
        public EvaluationResult EvaluationResult { get; set; }
        public int CompetencyId { get; set; }
        public Competency Competency { get; set; }

    }
}
