using System.Collections.Generic;

namespace PL_Proyect.LexerParserClases
{
    public sealed class UnaryEvalSyntxBinary : EvalSyntax
    {
        public UnaryEvalSyntxBinary(SntxToken evaluator, EvalSyntax opperand)
        {
            
            Evaluator = evaluator;
            Opperand = opperand;
        }

      
        public SntxToken Evaluator { get; }
        public EvalSyntax Opperand { get; }

        public override TypeOfSyntax Type => TypeOfSyntax.UnaryBinaryEvaluator;

        public override IEnumerable<SntxNode> GetChildren()
        {
         
            yield return Evaluator;
            yield return Opperand;
        }
    }
}
