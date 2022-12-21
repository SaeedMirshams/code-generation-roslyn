using System.Security.AccessControl;

namespace AntlrPuml.GenerationInfo
{
    public partial class EnumDto
    {
        internal void GenerateEnum()
        {
            var folderName = NameSpace + ".Domain\\Enums";
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
            var fileName = folderName + "\\" + Name + ".cs";
            if (!Forced && File.Exists(fileName))
            {
                Console.WriteLine($"{fileName} Ignored.");
                return;
            }
            StreamWriter csFile = new StreamWriter(fileName);
            csFile.WriteLine("namespace " + NameSpace + ".Domain.Enums");
            csFile.WriteLine("{");
            csFile.WriteLine("    public enum " + Name);
            csFile.WriteLine("    {");
            for (int i = 0; i < Fields.Count; i++)
            {
                var field = Fields[i];
                if (field.StreoTypes.Count > 0)
                {
                    csFile.WriteLine("  /// <summary>");
                    foreach (var comment in field.StreoTypes)
                    {
                        csFile.WriteLine("  /// " + comment.Replace("\r", "").Replace("\n", ""));
                    }
                    csFile.WriteLine("/// </summary>");
                }
                csFile.WriteLine($"        {field.Name}" + (i < Fields.Count ? ',' : ' '));

            }
            csFile.WriteLine("");
            csFile.WriteLine("    }");
            csFile.WriteLine("}");

            csFile.Flush();
            csFile.Close();
            csFile.Dispose();

        }
    }
}