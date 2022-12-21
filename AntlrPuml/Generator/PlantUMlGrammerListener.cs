using AntlrPuml.GenerationInfo;

namespace iasco.puml;

public sealed class PlantUMlGrammerListener : PlantUMLGrammerBaseListener
{
    private readonly List<NamespaceDto> _namespaces = new();

    public List<NamespaceDto> NameSpaces => _namespaces;
    internal NamespaceDto CurrentNamespace = new NamespaceDto { Name = "Global" };
    internal ClassDto CurrentClass = null;
    internal EnumDto CurrentEnum = null;

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
        var cls = new ClassDto { Name = Name };
        foreach (var item in context.streotype_def())
        {
            cls.StreoTypes.Add(item.streotypename().GetText());
            cls.BaseType = item.streotypename().GetText();
            if (item.generic_name() != null)
                cls.GenericType = item.generic_name().GetText();
        }
        CurrentClass = cls;
        CurrentNamespace.Classes.Add(cls);
    }

    public override void EnterEnum_def(PlantUMLGrammerParser.Enum_defContext context)
    {
        var Name = context.enum_name().GetText();
        var enumdto = new EnumDto { Name = Name };
        CurrentEnum = enumdto;
        CurrentNamespace.Enums.Add(enumdto);

    }


    public override void EnterEnum_field_def_block(PlantUMLGrammerParser.Enum_field_def_blockContext context)
    {
        if (CurrentEnum == null)
        {
            Console.WriteLine("No current class found for Field Def.");
            return;
        }

        foreach (var item in context.enum_field_def())
        {

            if (item.method_field() == null || item.method_field().GetText() == "field")
            {
                var field = new EnumFieldDto();
                field.Name = item.fieldName().GetText();
                CurrentEnum.Fields.Add(field);
                foreach (var stt in item.enum_field_streo_type())
                {
                    field.StreoTypes.Add(stt.enumcomment().GetText());
                }
            }
            else
                CurrentEnum.Methods.Add(item.fieldName().GetText());

        }

    }

    public override void EnterField_def(PlantUMLGrammerParser.Field_defContext context)
    {

        var Name = context.fieldName().GetText();
        var field = new FieldDto { Name = Name };
        field.AccessModifier = context.accessor().GetText();
        field.FieldType = context.fieldType().GetText();
        foreach (var streotype in context.fieldstreotype())
        {
            field.StreoTypes.Add(streotype.GetText());
        }
        foreach (var item in context.fieldstreotype())
        {
            field.StreoTypes.Add(item.streotypename().GetText());
        }
        if (CurrentClass != null)
            CurrentClass.ExplicitFields.Add(field);
        else
        {
            Console.WriteLine("No current class found for Field Def.");
        }
    }


    public override void EnterRelation(PlantUMLGrammerParser.RelationContext context)
    {
        var From = context.from().GetText();
        var To = context.to().GetText();
        AddClass(From);
        AddClass(To);

        var typ = context.relationType().GetText();
        var RelationType = typ;

        var MultiplicityFrom = context.multiplicity_from() != null ? context.multiplicity_from().GetText() : "1";
        var MultiplicityTo = context.multiplicity_to() != null ? context.multiplicity_to().GetText() : "1";
        CurrentNamespace.Relations.Add(new RelationDto
        {
            From = From,
            To = To,
            RelationType = RelationType,
            MultiplicityFrom = MultiplicityFrom.Replace("\"", ""),
            MultiplicityTo = MultiplicityTo.Replace("\"", "")
        });
    }

    private ClassDto AddClass(string ClassName)
    {
        var clas = CurrentNamespace.Classes.Find(x => x.Name.Equals(ClassName));
        var enu = CurrentNamespace.Enums.Find(x => x.Name.Equals(ClassName));
        if (clas == null && enu == null)
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
        var fld = new FieldDto { Name = FieldName, AccessModifier = accessor, FieldType = typ, };
        foreach (var item in context.fieldstreotype())
        {
            fld.StreoTypes.Add(item.streotypename().GetText());

        }
        clas.ExplicitFields.Add(fld);

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