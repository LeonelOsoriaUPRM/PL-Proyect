using System.Collections.Generic;

namespace BabyCsharpProject.LexerParserClases
{
    public sealed class NumEvalSyntx : EvalSyntax
    {
        public NumEvalSyntx(SntxToken numToken)
        {
            NumToken = numToken;
            //something will go here later
        }

        public override TypeOfSyntax Type => TypeOfSyntax.EvalNumber;
        public SntxToken NumToken { get; }

        public override IEnumerable<SntxNode> GetChildren()
        {
            yield return NumToken;
        }
    }
}
