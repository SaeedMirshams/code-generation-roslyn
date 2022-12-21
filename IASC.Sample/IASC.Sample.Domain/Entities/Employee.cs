using IASC.Core.Entities;
namespace IASC.Sample.Domain.Entities
{
    public class Employee : Entity<int>
    {
        public string PersonelNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<SuccessorRepository> SuccessorRepositorys { get; set; }
        public virtual ICollection<DevelopmentProgram> DevelopmentPrograms { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public virtual ICollection<EvaluationResult> EvaluationResults { get; set; }

    }
}
