namespace iasco.puml; 
public partial class ClassDto
{
    public string Name { get; set; }
    public bool IsAbstract { get; set; }=false;

    public Accessor Accessor;
    public List<FieldDto> fields { get; set; } = new();
    public string Color { get; internal set; }
    public string NameSpace { get; internal set; }
    public bool Forced { get; internal set; }
}
