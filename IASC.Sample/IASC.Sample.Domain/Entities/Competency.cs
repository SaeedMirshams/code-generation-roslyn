using IASC.Core.Entities;
using IASC.Sample.Domain.Enums;
namespace IASC.Sample.Domain.Entities
{
    public class Competency : Entity<int>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CompetencyCategoryId { get; set; }
        public CompetencyCategory CompetencyCategory { get; set; }
        public virtual ICollection<CompetencyModel> CompetencyModels { get; set; }
        public virtual ICollection<PostCompetency> PostCompetencys { get; set; }
        public CompetencyType CompetencyType { get; set; }
        public virtual ICollection<CompetencyScore> CompetencyScores { get; set; }
        public virtual ICollection<DevelopmentProgramItem> DevelopmentProgramItems { get; set; }

    }
}
