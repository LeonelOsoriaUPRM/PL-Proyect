using System;

namespace BabyCsharpProject.LexerParserClases.Binding
{
    internal sealed class BoundBinaryExpress : BoundExpress
    {
        public BoundBinaryExpress(BoundExpress left, BoundBinaryOppType TypeOfOperator, BoundExpress right)
        {
            Left = left;
            this.TypeOfOperator = TypeOfOperator;
            Right = right;
        }

        public BoundExpress Left { get; }
        public BoundBinaryOppType TypeOfOperator { get; }
        public BoundExpress Right { get; }
        public override Type Type => Left.Type;
        public override BoundNodeType Kind => BoundNodeType.BoundUnaryExpress;
    }
}
