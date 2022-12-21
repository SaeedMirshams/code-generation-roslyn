
using IASC.Core.Application.DTOs;
using IASC.Core.Application.Mappings;
using IASC.Sample.Domain.Enums;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Application.DTOs

{
public class SuccessorRepositoryDto : EntityDto<int>,IMapFrom<SuccessorRepository>
    {
        public int Order { get; set; }
        public RepositoryRecommenderType RepositoryRecommenderType { get; set; }
    }
}
