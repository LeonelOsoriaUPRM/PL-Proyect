using System.Collections.Generic;

namespace PL_Proyect.LexerParserClases
{
    public sealed class ParenExpressSntx : EvalSyntax
    {
        public ParenExpressSntx(SntxToken openParenToken, EvalSyntax express, SntxToken closeParenToken)
        {
            OpenParenToken = openParenToken;
            Express = express;
            CloseParenToken = closeParenToken;
        }

        public SntxToken OpenParenToken { get; }
        public EvalSyntax Express { get; }
        public SntxToken CloseParenToken { get; }

        public override TypeOfSyntax Type => TypeOfSyntax.ParenExpressSntx;

        public override IEnumerable<SntxNode> GetChildren()
        {
            yield return OpenParenToken;
            yield return Express;
            yield return CloseParenToken;

        }
    }
}
