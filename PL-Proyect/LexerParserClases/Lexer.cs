using System.Collections.Generic;

namespace PL_Proyect.LexerParserClases
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
        private char CurrentP
        {
            get
            {
                if (this.currentPos >= this.textString.Length)
                {
                    return '\0';
                }
                else { return this.textString[this.currentPos]; }

            }
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
                int.TryParse(textString, out var value);
                return new SntxToken(TypeOfSyntax.WhtSpToken, begining, textString, null);
            }
            if (CurrentP == '+')
            {
                return new SntxToken(TypeOfSyntax.SumToken, this.currentPos++, "+", null);
            }
            else if (CurrentP == '-')
            {
                return new SntxToken(TypeOfSyntax.SubToken, this.currentPos++, "-", null);
            }
            else if (CurrentP == '/')
            {
                return new SntxToken(TypeOfSyntax.DivToken, this.currentPos++, "/", null);
            }
            else if (CurrentP == '*')
            {
                return new SntxToken(TypeOfSyntax.MultToken, this.currentPos++, "*", null);
            }
            else if (CurrentP == '=')
            {
                return new SntxToken(TypeOfSyntax.EqToken, this.currentPos++, "=", null);
            }
            else if (CurrentP == '(')
            {
                return new SntxToken(TypeOfSyntax.LftParToken, this.currentPos++, "(", null);
            }
            else if (CurrentP == ')')
            {
                return new SntxToken(TypeOfSyntax.RgtParToken, this.currentPos++, ")", null);
            }
            this.diagnostics.Add($"ERROR: Unrecognized Character On Input Stream: '{this.currentPos}'");
            return new SntxToken(TypeOfSyntax.NotReconToken, this.currentPos++, this.textString.Substring(this.currentPos - 1, 1), null);

        }



    }
}
