using System.Collections.Generic;

namespace PL_Proyect.LexerParserClases
{
    public sealed class EvalSyntxBinary : EvalSyntax
    {
        public EvalSyntxBinary(EvalSyntax leftSyn, SntxToken evaluator, EvalSyntax rightSyn)
        {
            LeftSyn = leftSyn;
            Evaluator = evaluator;
            RightSyn = rightSyn;
        }

        public EvalSyntax LeftSyn { get; }
        public SntxToken Evaluator { get; }
        public EvalSyntax RightSyn { get; }

        public override TypeOfSyntax Type => TypeOfSyntax.BinaryEvaluator;

        public override IEnumerable<SntxNode> GetChildren()
        {
            yield return LeftSyn;
            yield return Evaluator;
            yield return RightSyn;
        }
    }
}
