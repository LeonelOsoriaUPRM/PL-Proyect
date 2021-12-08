using System;

namespace BabyCsharpProject.LexerParserClases.Binding
{
    internal sealed class BoundLiteralExpress : BoundExpress
    {
        public BoundLiteralExpress(object value)//why this object
        {
            Value = value;
        }

        public object Value { get; }// why this object
        public override Type Type => Value.GetType();
        public override BoundNodeType Kind => BoundNodeType.BoundLiteralExpress;
    }
}
