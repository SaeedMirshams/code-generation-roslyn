using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Tree;
using iasco.puml;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("*                                                                          *");
        Console.WriteLine("*   PlantUml to create C# skeleton from a PlantUml file                    *");
        Console.WriteLine("*   To convert specify a .plantUml file or a directory                     *");
        Console.WriteLine("*           To Clean Architecure Solution                                  *");
        Console.WriteLine("****************************************************************************");
        bool Forced = args.Length > 0 && args.Contains("-f");

        var text = File.ReadAllText("model.md");

        var su = text.IndexOf("@startuml");
        text = text.Remove(0, su);
        var eu = text.IndexOf("```");
        text = text.Substring(0, eu);

        var stream = CharStreams.fromString(text);
        var lexer = new PlantUMLGrammerLexer(stream);
        var tokens = new CommonTokenStream(lexer);
        var parser = new PlantUMLGrammerParser(tokens) { BuildParseTree = true/*,Trace=true*/};

        var parseTree = parser.file();
        var listener = new PlantUMlGrammerListener();
        ParseTreeWalker.Default.Walk(listener, parseTree);
        foreach (var namespaceDto in listener.NameSpaces)
        {
            Console.WriteLine($"{namespaceDto.Name}:");
            Console.WriteLine("-------Classes----------");
            foreach (var cls in namespaceDto.Classes)
            {
                cls.NameSpace = namespaceDto.Name;
                cls.Forced = Forced;
                var relations = namespaceDto.Relations.FindAll(x => x.From == cls.Name);
                foreach (var rel in relations)
                {
                    var RelatedClass = namespaceDto.Classes.Find(x => x.Name == rel.To);
                    if (RelatedClass != null)
                    {
                        switch (rel.RelationType)
                        {
                            case "<-->":
                            case "-->":
                            case "--":
                            case "*--":
                            case "*-":
                                break;
                            case "<|--":
                            case "--|>":
                            case "<--":
                            case "-":
                            case "--*":
                            case "-*":
                            default: continue;


                        }
                        if (rel.MultiplicityTo.Contains("*"))
                        {
                            var PName = rel.To + "s";
                            if (rel.MultiplicityTo.Contains(","))
                            {
                                PName = rel.MultiplicityTo.Split(',')[1];
                            }
                            cls.RelationFields.Add(new FieldDto { AccessModifier = "+", FieldType = "virtual ICollection<" + rel.To + ">", Name = PName });
                        }
                        else
                        {
                            var PName = rel.To;
                            if (rel.MultiplicityTo.Contains(","))
                            {
                                PName = rel.MultiplicityTo.Split(',')[1];
                            }

                            cls.RelationFields.Add(new FieldDto { AccessModifier = "+", FieldType = RelatedClass.GenericType, Name = PName + "Id" });
                            cls.RelationFields.Add(new FieldDto { AccessModifier = "+", FieldType = rel.To, Name = PName });
                        }
                    }
                    else
                    {
                        cls.IsUsingEnums = true;
                        var PName = rel.To;
                        if (rel.MultiplicityTo.Contains(","))
                        {
                            PName = rel.MultiplicityTo.Split(',')[1];
                        }

                        cls.RelationFields.Add(new FieldDto { AccessModifier = "+", FieldType = rel.To, Name = PName, IsEnumRelated = true });
                    }
                }
                var relationsto = namespaceDto.Relations.FindAll(x => x.To == cls.Name);
                foreach (var rel in relationsto)
                {
                    var RelatedClass = namespaceDto.Classes.Find(x => x.Name == rel.From);
                    if (RelatedClass != null)
                    {
                        switch (rel.RelationType)
                        {
                            case "<-->":
                            case "<--":
                            case "--":
                            case "--*":
                            case "-*":
                            case "*--":
                                break;

                            case "<|--":
                            case "-->":
                            case "--|>":
                            case "*-":
                            case "-":
                            default: continue;
                        }


                        if (rel.MultiplicityFrom.Contains("*"))
                        {
                            var PName = rel.From + "s";
                            if (rel.MultiplicityFrom.Contains(","))
                            {
                                PName = rel.MultiplicityFrom.Split(',')[1];
                            }

                            cls.RelationFields.Add(new FieldDto { AccessModifier = "+", FieldType = "virtual ICollection<" + rel.From + ">", Name = PName });
                        }
                        else
                        {
                            var PName = rel.From;
                            if (rel.MultiplicityFrom.Contains(","))
                            {
                                PName = rel.MultiplicityFrom.Split(',')[1];
                            }

                            cls.RelationFields.Add(new FieldDto { AccessModifier = "+", FieldType = RelatedClass.GenericType, Name = PName + "Id" });
                            cls.RelationFields.Add(new FieldDto { AccessModifier = "+", FieldType = rel.From, Name = PName });
                        }
                    }
                    else
                    {
                        cls.IsUsingEnums = true;
                        var PName = rel.From;
                        if (rel.MultiplicityFrom.Contains(","))
                        {
                            PName = rel.MultiplicityFrom.Split(',')[1];
                        }

                        cls.RelationFields.Add(new FieldDto { AccessModifier = "+", FieldType = rel.From, Name = PName, IsEnumRelated = true });
                    }
                }

                cls.GenerateEntity();
                cls.GenerateBriefDtos();
                cls.GenerateDtos();
                cls.GenerateConfigurations();

                cls.GenerateCreateCommand();
                cls.GenerateCreateCommandValidator();

                cls.GenerateDeleteCommand();
                cls.GenerateDeleteCommandValidator();

                cls.GenerateUpdateCommand();
                cls.GenerateUpdateCommandValidator();

                cls.GenerateGetByIDQuery();
                cls.GenerateGetByIDQueryValidator();

                cls.GenerateGetWithPaginationQuery();
                cls.GenerateGetWithPaginationQueryValidator();

                cls.GenerateController();


                Console.WriteLine($" {cls.Name}:");
                foreach (var field in cls.ExplicitFields)
                {
                    Console.WriteLine($"  {field.AccessModifier} {field.FieldType} {field.Name};");
                }
            }

            foreach (var enumitem in namespaceDto.Enums)
            {
                enumitem.NameSpace = namespaceDto.Name;
                enumitem.Forced = Forced;
                enumitem.GenerateEnum();

            }

            Console.WriteLine("---------Relations----------");
            foreach (var relation in namespaceDto.Relations)
            {
                Console.WriteLine($" {relation.From} {relation.RelationType} {relation.To}");
            }


        }
    }
}