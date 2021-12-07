using System.Collections.Generic;
using System.Linq;

namespace BabyCsharpProject.LexerParserClases
{
    public sealed class SntxToken : SntxNode
    {
        public SntxToken(TypeOfSyntax type, int position, string textString, object value)
        {
            Type = type;
            Position = position;
            TextString = textString;
            Value = value;
        }

        public override TypeOfSyntax Type { get; }
        public int Position { get; }
        public string TextString { get; }
        public object Value { get; }

        public override IEnumerable<SntxNode> GetChildren()
        {
            return Enumerable.Empty<SntxNode>();
        }
    }
}
