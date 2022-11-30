namespace iasco.puml;
public class FieldDto
{
    public string Name { get; set; }
    private Accessor _Accessor;
    public string AccessModifier
    {
        get
        {
            switch (_Accessor)
            {
                case Accessor.Private:
                    return "private";
                    break;
                case Accessor.Protected:
                    return "protected";
                    break;
                case Accessor.Internal:
                    return "internal";
                    break;
                case Accessor.Public:
                    return "public";
                    break;
                default:
                    return _Accessor.ToString();
                    break;
            }
        }
        set
        {
            switch (value)
            {
                case "+":
                    _Accessor = Accessor.Public;
                    break;
                case "-":
                    _Accessor = Accessor.Private;
                    break;
                case "#":
                    _Accessor = Accessor.Protected;
                    break;
                case "~":
                    _Accessor = Accessor.Internal;
                    break;
                default:
                    break;
            }

        }
    }
    public string FieldType { get; set; }
}