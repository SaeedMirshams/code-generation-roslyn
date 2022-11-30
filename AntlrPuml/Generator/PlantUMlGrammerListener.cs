namespace iasco.puml;

public sealed class PlantUMlGrammerListener : PlantUMLGrammerBaseListener
{
    private readonly List<NamespaceDto> _namespaces = new();

    public List<NamespaceDto> NameSpaces => _namespaces;
    internal NamespaceDto CurrentNamespace = new NamespaceDto { Name = "Global" };
    public override void EnterFile(PlantUMLGrammerParser.FileContext context)
    {
        /*foreach (var definition in context.type_definition())
        {
            var identifier = definition.GetText();
            Console.WriteLine(identifier);
        }*/

    }

    public override void EnterNamespace_def(PlantUMLGrammerParser.Namespace_defContext context)
    {
        var Name = context.namespace_name().GetText();
        CurrentNamespace = new NamespaceDto { Name = Name };
        _namespaces.Add(CurrentNamespace);
    }

    public override void EnterClass_def(PlantUMLGrammerParser.Class_defContext context)
    {
        var Name = context.class_name().GetText();
        CurrentNamespace.Classes.Add(new ClassDto { Name = Name });
    }


    public override void EnterAbstractclass_def(PlantUMLGrammerParser.Abstractclass_defContext context)
    {
        var Name = context.class_name().GetText();
        var color = context.color() != null ? context.color().GetText() : "";
        CurrentNamespace.Classes.Add(new ClassDto { Name = Name, IsAbstract = true, Color = color });
    }

    public override void EnterRelation(PlantUMLGrammerParser.RelationContext context)
    {
        var From = context.from().GetText();
        var To = context.to().GetText();
        AddClass(From);
        AddClass(To);
        var typ = context.relationType().GetText();
        var RelationType = "";
        switch (typ)
        {
            case "--|>":
                (From, To) = (To, From);
                RelationType = "Inheritance";
                break;
            case "<|--":
                RelationType = "Inheritance";
                break;

            default:
                RelationType = typ;
                break;
        }
        CurrentNamespace.Relations.Add(new RelationDto { From = From, To = To, RelationType = RelationType, Multiplicity = "unknown" });
    }

    private ClassDto AddClass(string ClassName)
    {
        var clas = CurrentNamespace.Classes.Find(x => x.Name.Equals(ClassName));
        if (clas == null)
        {
            clas = new ClassDto();
            clas.Name = ClassName;
            CurrentNamespace.Classes.Add(clas);
        }
        return clas;
    }

    public override void EnterExtrafield(PlantUMLGrammerParser.ExtrafieldContext context)
    {
        var ClassName = context.ownerClass().GetText();
        var FieldName = context.fieldName().GetText();
        var typ = context.fieldType().GetText();
        var accessor = context.accessor().GetText();
        var clas = AddClass(ClassName);
        clas.fields.Add(new FieldDto { Name = FieldName, AccessModifier = accessor, FieldType = typ, });

    }


    public override void EnterNote_expr(PlantUMLGrammerParser.Note_exprContext context)
    {
        var somethings = context.somethingsToEndNote().GetText();
        Console.WriteLine($"/* NOTE:{somethings} */");

    }


    public override void EnterInterface_def(PlantUMLGrammerParser.Interface_defContext context)
    {
        var InterfaceName = context.interface_name().GetText();
        AddClass(InterfaceName);

    }


}