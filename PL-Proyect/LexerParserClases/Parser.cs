using System.Collections.Generic;

namespace PL_Proyect.LexerParserClases
{
    class Parser
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
        private SntxToken Match(TypeOfSyntax Type)
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
            var espress = ParseTerm();
            var FileEndToken = Match(TypeOfSyntax.FileEndToken);
            return new SntxTree(this.diagnostics, espress, FileEndToken);
        }
        private EvalSyntax ParseTerm()
        {
            var leftSyn = ParseFactor();

            while (CurrentP.Type == TypeOfSyntax.SubToken || CurrentP.Type == TypeOfSyntax.SumToken)
            {
                var opToken = NextToken();
                var rightSyn = ParseFactor();
                leftSyn = new EvalSyntxBinary(leftSyn, opToken, rightSyn);
            }
            return leftSyn;
        }
        private EvalSyntax ParseFactor()
        {
            var leftSyn = FirstExpEval();

            while (CurrentP.Type == TypeOfSyntax.MultToken || CurrentP.Type == TypeOfSyntax.DivToken)
            {
                var opToken = NextToken();
                var rightSyn = FirstExpEval();
                leftSyn = new EvalSyntxBinary(leftSyn, opToken, rightSyn);
            }
            return leftSyn;
        }



        private EvalSyntax FirstExpEval()
        {
            if (CurrentP.Type == TypeOfSyntax.LftParToken)
            {
                var left = NextToken();
                var express = ParseExpress();
                var right = Match(TypeOfSyntax.RgtParToken);
                return new ParenExpressSntx(left, express, right);
            }

            var numToken = Match(TypeOfSyntax.NumToken);
            return new NumEvalSyntx(numToken);
        }

        private EvalSyntax ParseExpress()
        {
            return ParseTerm();
        }
    }
}
