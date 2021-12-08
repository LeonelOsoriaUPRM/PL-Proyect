using System;

namespace BabyCsharpProject.LexerParserClases.Binding
{
    internal abstract class BoundExpress : BoundNode
    {
        public abstract Type Type { get; }
    }
}
