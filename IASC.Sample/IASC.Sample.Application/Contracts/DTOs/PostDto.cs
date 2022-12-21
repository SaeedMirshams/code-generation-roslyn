
using IASC.Core.Application.DTOs;
using IASC.Core.Application.Mappings;
using IASC.Sample.Domain.Entities;
namespace IASC.Sample.Application.DTOs

{
public class PostDto : EntityDto<int>,IMapFrom<Post>
    {
        public string Code { get; set; }
        public string Title { get; set; }
    }
}
