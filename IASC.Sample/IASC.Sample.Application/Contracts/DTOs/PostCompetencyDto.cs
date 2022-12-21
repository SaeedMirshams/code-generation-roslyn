
using IASC.Core.Application.DTOs;
using IASC.Core.Application.Mappings;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Application.DTOs

{
public class PostCompetencyDto : EntityDto<int>,IMapFrom<PostCompetency>
    {
        public string Quorum { get; set; }
        public double Weight { get; set; }
    }
}
