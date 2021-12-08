using System;

namespace BabyCsharpProject.LexerParserClases.Binding
{
    internal sealed class BoundUnaryExpress : BoundExpress
    {
        public BoundUnaryExpress(BoundUnaryOppType operatorKind, BoundExpress opperand)
        {
            OperatorKind = operatorKind;
            Opperand = opperand;
        }

        public BoundUnaryOppType OperatorKind { get; }

        public BoundExpress Opperand { get; }

        public override Type Type => Opperand.Type;

        public override BoundNodeType Kind => BoundNodeType.BoundUnaryExpress;
    }
}
