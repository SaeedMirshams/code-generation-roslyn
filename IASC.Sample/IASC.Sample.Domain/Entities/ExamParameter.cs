using IASC.Core.Entities;
namespace IASC.Sample.Domain.Entities
{
    public class ExamParameter : Entity<int>
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Quorum { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ExamScore> ExamScores { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }

    }
}
