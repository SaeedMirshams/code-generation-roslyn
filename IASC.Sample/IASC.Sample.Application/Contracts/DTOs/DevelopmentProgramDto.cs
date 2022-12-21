
using IASC.Core.Application.DTOs;
using IASC.Core.Application.Mappings;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Application.DTOs

{
public class DevelopmentProgramDto : EntityDto<int>,IMapFrom<DevelopmentProgram>
    {
        public string Goal { get; set; }
    }
}
