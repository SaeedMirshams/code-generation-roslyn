using Antlr4.Runtime;
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


        var text = File.ReadAllText("model.md");

        var su = text.IndexOf("@startuml");
        text = text.Remove(0, su);
        var eu = text.IndexOf("```");
        text = text.Substring(0, eu);

        var stream = CharStreams.fromString(text);
        var lexer = new PlantUMLGrammerLexer(stream);
        var tokens = new CommonTokenStream(lexer);
        var parser = new PlantUMLGrammerParser(tokens) { BuildParseTree = true };

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


                Console.WriteLine($" {cls.Name}:");
                foreach (var field in cls.fields)
                {
                    Console.WriteLine($"  {field.AccessModifier} {field.FieldType} {field.Name};");
                }
            }

            Console.WriteLine("---------Relations----------");
            foreach (var relation in namespaceDto.Relations)
            {
                Console.WriteLine($" {relation.From} {relation.RelationType} {relation.To}");
            }


        }
    }
}