using System.Collections.Generic;
using System.Linq;

namespace BabyCsharpProject.LexerParserClases
{
    public sealed class SntxTree
    {
        public SntxTree(IEnumerable<string> diagnostics, EvalSyntax root, SntxToken FileEndToken)
        {
            Diagnostics = diagnostics.ToArray();
            Root = root;
            this.FileEndToken = FileEndToken;
        }

        public IReadOnlyList<string> Diagnostics { get; }
        public EvalSyntax Root { get; }
        public SntxToken FileEndToken { get; }

        public static SntxTree Parse(string text)
        {
            var parser = new Parser(text);
            return parser.Parse();
        }
    }
}
