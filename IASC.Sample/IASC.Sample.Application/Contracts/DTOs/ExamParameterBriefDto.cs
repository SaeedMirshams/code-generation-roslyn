
using IASC.Core.Application.DTOs;
using IASC.Core.Application.Mappings;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Application.DTOs;

public class ExamParameterBriefDto : EntityDto<int>,IMapFrom<ExamParameter>
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Quorum { get; set; }
        public string Description { get; set; }
    }
