using System.Collections.Generic;

namespace PL_Proyect.LexerParserClases
{
    public abstract class SntxNode
    {
        public abstract TypeOfSyntax Type { get; }

        public abstract IEnumerable<SntxNode> GetChildren();

    }
}
