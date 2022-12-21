using IASC.Core.Entities;
namespace IASC.Sample.Domain.Entities
{
    public class Post : Entity<int>
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<SuccessorRepository> SuccessorRepositorys { get; set; }
        public virtual ICollection<PostCompetency> PostCompetencys { get; set; }

    }
}
