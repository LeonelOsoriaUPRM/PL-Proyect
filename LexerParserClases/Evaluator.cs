using BabyCsharpProject.LexerParserClases.Binding;
using BabyCsharpProject.LexerParserClases.Syntax;
using System;
using System.Text;

namespace BabyCsharpProject.LexerParserClases
{
    internal sealed class Evaluator
    {
        private readonly BoundExpress root;
        public Evaluator(BoundExpress root)
        {
            this.root = root;
        }

        public object Evaluate()
        {
            return EvaluateExpress(this.root);
        }

        private object EvaluateExpress(BoundExpress node)
        {
            //binary and number expresions
            if (node is BoundLiteralExpress n)
            {
                return n.Value;
            }if(node is BoundUnaryExpress u)
            {
                var opperand = EvaluateExpress(u.Opperand);
                switch (u.OperatorKind)
                {
                    case BoundUnaryOppType.Identity:
                        return (int)opperand;
                    case BoundUnaryOppType.Negation:
                        return -(int)opperand;
                    case BoundUnaryOppType.LogicNegation:
                        return !(bool)opperand;
                    default:
                        throw new Exception($"Unexpected unary operator {u.OperatorKind}");
                }
            }
            if (node is BoundBinaryExpress b)
            {
                var left = EvaluateExpress(b.Left);
                var right = EvaluateExpress(b.Right);
                switch (b.TypeOfOperator)
                {
                    case BoundBinaryOppType.Add:
                        return (int) left + (int) right;
                    case BoundBinaryOppType.Sub:
                        return (int) left - (int) right;
                    case BoundBinaryOppType.Mult:
                        return (int) left * (int) right;
                    case BoundBinaryOppType.Div:
                        return (int) left / (int) right;
                    case BoundBinaryOppType.OppAND:
                        return (bool) left && (bool) right;
                    case BoundBinaryOppType.OppOR:
                        return (bool) left || (bool) right;

                    default:
                        throw new Exception($"Unexpected binary operator {b.TypeOfOperator}");
                }

            }
            /*
            if (node is ParenExpressSntx p)
            {
                return EvaluateExpress(p.Express);
            }*/
            throw new Exception($"Unexpected node {node.Type}");
            
        }
    }
}
