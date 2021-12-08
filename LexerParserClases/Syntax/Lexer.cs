using System.Collections.Generic;

namespace BabyCsharpProject.LexerParserClases.Syntax
{
    internal sealed class Lexer
    {
        private readonly string textString;
        private int currentPos;

        private List<string> diagnostics = new List<string>();
        public Lexer(string textString)
        {
            this.textString = textString;
        }

        public IEnumerable<string> Diagnostic => this.diagnostics;
        private char CurrentP => Peek(0);
        private char lookAhead => Peek(1);
        private char Peek(int offset)
        {
            if (this.currentPos >= this.textString.Length)
            {
                return '\0';
            }
            else { return this.textString[this.currentPos]; }
        }

        private void NextPos()
        {
            this.currentPos++;
        }

        public SntxToken NxtToken()
        {
            if (this.currentPos >= this.textString.Length)
            {
                return new SntxToken(TypeOfSyntax.FileEndToken, this.currentPos, "\0", null);
            }
            if (char.IsDigit(CurrentP))
            {
                var begining = this.currentPos;

                while (char.IsDigit(CurrentP))
                    NextPos();

                var length = this.currentPos - begining;
                var textString = this.textString.Substring(begining, length);
                if (!int.TryParse(textString, out var value))
                {
                    this.diagnostics.Add($"ERROR: Number {this.textString} not valid Int32");
                }
                return new SntxToken(TypeOfSyntax.NumToken, begining, textString, value);

            }
            if (char.IsWhiteSpace(CurrentP))
            {
                var begining = this.currentPos;

                while (char.IsWhiteSpace(CurrentP))
                    NextPos();

                var length = this.currentPos - begining;
                var textString = this.textString.Substring(begining, length);
                
                return new SntxToken(TypeOfSyntax.WhtSpToken, begining, textString, null);
            }
            if (char.IsLetter(CurrentP))
            {
                var begining = this.currentPos;

                while (char.IsLetter(CurrentP))
                    NextPos();

                var length = this.currentPos - begining;
                var textString = this.textString.Substring(begining, length);
                var kind = SyntaxFacts.GetKeywordKind(textString);
                return new SntxToken(kind, begining, textString, null);
            }

            switch (CurrentP)
            {
                case '+':
                    return new SntxToken(TypeOfSyntax.SumToken, this.currentPos++, "+", null);
                case '-':
                    return new SntxToken(TypeOfSyntax.SubToken, this.currentPos++, "-", null);
                case '/':
                    return new SntxToken(TypeOfSyntax.SubToken, this.currentPos++, "-", null);
                case '*':
                    return new SntxToken(TypeOfSyntax.MultToken, this.currentPos++, "*", null);
                case '=':
                    return new SntxToken(TypeOfSyntax.EqToken, this.currentPos++, "=", null);
                case '(':
                    return new SntxToken(TypeOfSyntax.LftParToken, this.currentPos++, "(", null);
                case ')':
                    return new SntxToken(TypeOfSyntax.RgtParToken, this.currentPos++, ")", null);
                case '!':
                    return new SntxToken(TypeOfSyntax.NegationToken, this.currentPos++, "!", null);
                case '&':
                    if(lookAhead == '&')
                        return new SntxToken(TypeOfSyntax.LogicANDToken, this.currentPos+=2, "&&", null);
                    break;
                case '|':
                    if (lookAhead == '|')
                        return new SntxToken(TypeOfSyntax.LogicORToken, this.currentPos += 2, "||", null);
                    break;

            }
            this.diagnostics.Add($"ERROR: Unrecognized Character On Input Stream: '{this.currentPos}'");
            return new SntxToken(TypeOfSyntax.NotReconToken, this.currentPos++, this.textString.Substring(this.currentPos - 1, 1), null);
            
        }



    }
}
