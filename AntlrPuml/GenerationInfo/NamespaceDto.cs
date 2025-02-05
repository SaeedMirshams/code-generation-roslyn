using AntlrPuml.GenerationInfo;

namespace iasco.puml;
public class NamespaceDto
{
    public String Name { get; set; }
    public List<ClassDto> Classes { get; set; } = new();
    public List<RelationDto> Relations { get; set; } = new();

    public List<EnumDto> Enums { get; set; } = new();   
}