using IASC.Core.Entities;
namespace IASC.Sample.Domain.Entities
{
    public class PostCompetency : Entity<int>
    {
        public string Quorum { get; set; }
        public double Weight { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public int CompetencyId { get; set; }
        public Competency Competency { get; set; }
        public int CompetencyModelId { get; set; }
        public CompetencyModel CompetencyModel { get; set; }

    }
}
