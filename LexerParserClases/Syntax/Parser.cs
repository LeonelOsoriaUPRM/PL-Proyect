using System.Collections.Generic;

namespace BabyCsharpProject.LexerParserClases.Syntax
{
    internal sealed class Parser
    {
        private readonly SntxToken[] tokenList;

        private List<string> diagnostics = new List<string>();
        private int tokenPos;

        public Parser(string textString)
        {
            var tokenList = new List<SntxToken>();
            var lexer = new Lexer(textString);
            SntxToken textToken;
            do
            {
                textToken = lexer.NxtToken();

                if (textToken.Type != TypeOfSyntax.WhtSpToken && textToken.Type != TypeOfSyntax.NotReconToken)
                {
                    tokenList.Add(textToken);
                }

            } while (textToken.Type != TypeOfSyntax.FileEndToken);

            this.tokenList = tokenList.ToArray();
            this.diagnostics.AddRange(lexer.Diagnostic);
        }

        public IEnumerable<string> Diagnostics => this.diagnostics;
        private SntxToken Peek(int offset)
        {
            var index = this.tokenPos + offset;
            if (index >= this.tokenList.Length)
            {
                return this.tokenList[this.tokenList.Length - 1];

            }
            return this.tokenList[index];
        }
        private SntxToken CurrentP => Peek(0);
        private SntxToken NextToken()
        {
            var currentP = CurrentP;
            this.tokenPos++;
            return currentP;
        }
        private SntxToken MatchToken(TypeOfSyntax Type)
        {
            if (CurrentP.Type == Type)
            {
                return NextToken();
            }
            else
            {
                this.diagnostics.Add($"ERROR: Unexpected token <{CurrentP.Type}>, expected <{Type}>");
                return new SntxToken(Type, CurrentP.Position, null, null);
            }
        }

        public SntxTree Parse()
        {
            var espress = ParseExpress();
            var FileEndToken = MatchToken(TypeOfSyntax.FileEndToken);
            return new SntxTree(this.diagnostics, espress, FileEndToken);
        }
        private EvalSyntax ParseExpress(int parentPrecedence = 0)
        {
            EvalSyntax left;
            
            var unaryOpPrecedence = CurrentP.Type.GetUnaryBinOpPrecedence();
            if(unaryOpPrecedence != 0 && unaryOpPrecedence >= parentPrecedence)
            {
                var oppToken = NextToken();
                var opperand = ParseExpress(unaryOpPrecedence);
                left = new UnaryEvalSyntxBinary(oppToken, opperand);
            }
            else
            {
                left = FirstExpEval();
            }

            while (true)
            {
                var precedence = CurrentP.Type.GetBinOpPrecedence();
                if (precedence == 0 || precedence <= parentPrecedence)
                    break;

                var opToken = NextToken();
                var right = ParseExpress(precedence);
                left = new EvalSyntxBinary(left, opToken, right);
            }
            return left;
        }
       
        
       
        private EvalSyntax FirstExpEval()
        {
            switch (CurrentP.Type)
            {
                case TypeOfSyntax.LftParToken:
                    {
                        var left = NextToken();
                        var express = ParseExpress();
                        var right = MatchToken(TypeOfSyntax.RgtParToken);
                        return new ParenExpressSntx(left, express, right);
                    }

                case TypeOfSyntax.TrueKeyword:
                case TypeOfSyntax.FalseKeyword:
                    {
                        var KeywordToken = NextToken();
                        var value = KeywordToken.Type == TypeOfSyntax.TrueKeyword;
                        return new NumEvalSyntx(KeywordToken, value);
                    }
                    default:
                    {
                        var numToken = MatchToken(TypeOfSyntax.NumToken);
                        return new NumEvalSyntx(numToken);
                    }

            }

            
        }
    }
}
