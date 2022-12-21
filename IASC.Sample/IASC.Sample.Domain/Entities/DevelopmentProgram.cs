using IASC.Core.Entities;
namespace IASC.Sample.Domain.Entities
{
    public class DevelopmentProgram : AuditableEntity<int>
    {
        public string Goal { get; set; }
        public virtual ICollection<DevelopmentProgramItem> DevelopmentProgramItems { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int CurrentPostId { get; set; }
        public Post CurrentPost { get; set; }

    }
}
