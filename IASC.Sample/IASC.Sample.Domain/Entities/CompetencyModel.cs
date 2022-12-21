using IASC.Core.Entities;
namespace IASC.Sample.Domain.Entities
{
    public class CompetencyModel : Entity<int>
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<EvaluationPeriod> EvaluationPeriods { get; set; }
        public virtual ICollection<PostCompetency> PostCompetencys { get; set; }
        public virtual ICollection<Competency> Competencies { get; set; }

    }
}
