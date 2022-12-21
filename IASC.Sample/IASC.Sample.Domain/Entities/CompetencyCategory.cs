using IASC.Core.Entities;
namespace IASC.Sample.Domain.Entities
{
    public class CompetencyCategory : Entity<int>
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Competency> Competencies { get; set; }

    }
}
