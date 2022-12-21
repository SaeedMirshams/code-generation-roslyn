using System.Security.AccessControl;

namespace AntlrPuml.GenerationInfo
{
    public partial class EnumDto
    {
        internal string Name { get; set; }
        public List<EnumFieldDto> Fields { get; set; } = new();
        public List<string> Methods { get; set; } = new();
        public string NameSpace { get; internal set; }
        public bool Forced { get; internal set; }

       
    }
}