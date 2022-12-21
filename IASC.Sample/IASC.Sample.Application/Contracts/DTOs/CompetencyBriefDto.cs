
using IASC.Core.Application.DTOs;
using IASC.Core.Application.Mappings;
using IASC.Sample.Domain.Enums;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Application.DTOs;

public class CompetencyBriefDto : EntityDto<int>,IMapFrom<Competency>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CompetencyType CompetencyType { get; set; }
    }
