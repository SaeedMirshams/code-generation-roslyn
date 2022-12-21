
using IASC.Core.Application.DTOs;
using IASC.Core.Application.Mappings;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Application.DTOs;

public class ExamScoreBriefDto : EntityDto<int>,IMapFrom<ExamScore>
    {
        public double Score { get; set; }
    }
