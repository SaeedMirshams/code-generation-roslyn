
using IASC.Core.Application.DTOs;
using IASC.Core.Application.Mappings;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Application.DTOs;

public class CompetencyModelBriefDto : EntityDto<int>,IMapFrom<CompetencyModel>
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
