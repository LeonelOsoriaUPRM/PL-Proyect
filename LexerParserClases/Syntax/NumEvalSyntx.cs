using System.Collections.Generic;

namespace BabyCsharpProject.LexerParserClases.Syntax
{
    public sealed class NumEvalSyntx : EvalSyntax
    {
        public NumEvalSyntx(SntxToken numToken): this(numToken, numToken.Value)
        {
        }
        public NumEvalSyntx(SntxToken numToken, object value)
        {
            NumToken = numToken;
            Value = value;
            
        }

        public override TypeOfSyntax Type => TypeOfSyntax.EvalNumber;
        public SntxToken NumToken { get; }
        public object Value { get; }

        public override IEnumerable<SntxNode> GetChildren()
        {
            yield return NumToken;
        }
    }
}
