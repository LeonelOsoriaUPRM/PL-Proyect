using System.Collections.Generic;

namespace PL_Proyect.LexerParserClases
{
    public sealed class UnaryEvalSyntxBinary : EvalSyntax
    {
        public UnaryEvalSyntxBinary(SntxToken operatorToken, EvalSyntax opperand)
        {
            
            ;
            OperatorToken = operatorToken;
            Opperand = opperand;
        }

      
      
        public SntxToken OperatorToken { get; }
        public EvalSyntax Opperand { get; }

        public override TypeOfSyntax Type => TypeOfSyntax.UnaryBinaryEvaluator;

        public override IEnumerable<SntxNode> GetChildren()
        {
         
            yield return OperatorToken;
            yield return Opperand;
        }
    }
}
