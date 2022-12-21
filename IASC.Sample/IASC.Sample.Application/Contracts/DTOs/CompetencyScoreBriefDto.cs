
using IASC.Core.Application.DTOs;
using IASC.Core.Application.Mappings;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Application.DTOs;

public class CompetencyScoreBriefDto : EntityDto<int>,IMapFrom<CompetencyScore>
    {
        public double Score { get; set; }
    }
