using System.Collections.Generic;

namespace BabyCsharpProject.LexerParserClases.Syntax
{
    public abstract class SntxNode
    {
        public abstract TypeOfSyntax Type { get; }

        public abstract IEnumerable<SntxNode> GetChildren();

    }
}
