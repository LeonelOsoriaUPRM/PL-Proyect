using System;
using System.Text;

namespace PL_Proyect.LexerParserClases
{
    public sealed class Evaluator
    {
        private readonly EvalSyntax root;
        public Evaluator(EvalSyntax root)
        {
            this.root = root;
        }

        public int Evaluate()
        {
            return EvaluateExpress(this.root);
        }

        private int EvaluateExpress(EvalSyntax node)
        {
            //binary and number expresions
            if (node is NumEvalSyntx n)
            {
                return (int)n.NumToken.Value;
            }if(node is UnaryEvalSyntxBinary u)
            {
                var opperand = EvaluateExpress(u.Opperand);
                if (u.Opperand.Type == TypeOfSyntax.SubToken)
                    return -opperand;
                else if(u.Opperand.Type == TypeOfSyntax.SubToken)
                {
                    return opperand;
                }else
                    throw new Exception($"Unexpected unary operator {u.Opperand.Type}");
            }
            if (node is EvalSyntxBinary b)
            {
                var left = EvaluateExpress(b.LeftSyn);
                var right = EvaluateExpress(b.RightSyn);
                if (b.Evaluator.Type == TypeOfSyntax.SumToken)
                {
                    return left + right;
                }
                else if (b.Evaluator.Type == TypeOfSyntax.SubToken)
                {
                    return left - right;
                }
                else if (b.Evaluator.Type == TypeOfSyntax.MultToken)
                {
                    return left * right;
                }
                else if (b.Evaluator.Type == TypeOfSyntax.DivToken)
                {
                    return left / right;
                }
                else
                {
                    throw new Exception($"Unexpected binary operator {b.Evaluator.Type}");
                }

            }

            if (node is ParenExpressSntx p)
            {
                return EvaluateExpress(p.Express);
            }
            throw new Exception($"Unexpected node {node.Type}");

        }
    }
}
