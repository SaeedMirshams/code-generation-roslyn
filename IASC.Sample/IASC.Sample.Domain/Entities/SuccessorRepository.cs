using IASC.Core.Entities;
using IASC.Sample.Domain.Enums;
namespace IASC.Sample.Domain.Entities
{
    public class SuccessorRepository : AuditableEntity<int>
    {
        public int Order { get; set; }
        public RepositoryRecommenderType RepositoryRecommenderType { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
