using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;

namespace PL_Proyect
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World, we're making a compiler baby!");
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestForm());
            /*
            while (true)
            {
                Console.Write(">");
                var line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line))

                    return;
                var lexer = new Lexer(line);
                while (true)
                {
                    var stringToken = lexer.nxtToken();
                    if (stringToken.Type == TypeOfSyntax.FileEndToken)
                        break;
                    Console.Write($"{stringToken.Type}: '{stringToken.TextString} ");
                    if (stringToken.Value != null)
                        Console.WriteLine($"{stringToken.Value} ");
                    Console.WriteLine();
                }


            }*/

        }
    }


    class Lexer
    {
        private readonly string textString;
        private int currentPos;
        public Lexer(string textString)
        {
            this.textString = textString;
        }

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

        public SntxToken nxtToken()
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
                int.TryParse(textString, out var value);
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
            return new SntxToken(TypeOfSyntax.NotReconToken, this.currentPos++, this.textString.Substring(this.currentPos - 1, 1), null);

        }



    }
    enum TypeOfSyntax
    {
        NumToken,
        WhtSpToken,
        SumToken,
        SubToken,
        DivToken,
        MultToken,
        LftParToken,
        RgtParToken,
        NotReconToken,
        FileEndToken,
        EqToken
    }
    class SntxToken
    {
        public SntxToken(TypeOfSyntax type, int position, string textString, object value)
        {
            Type = type;
            Position = position;
            TextString = textString;
            Value = value;
        }

        public TypeOfSyntax Type { get; }
        public int Position { get; }
        public string TextString { get; }
        public object Value { get; }
    }
    class Parser
    {
        private readonly SntxToken[] tokenList;
        private int tokenPos;

        public Parser(string textString)
        {
            var tokenList = new List<SntxToken>();
            var lexer = new Lexer(textString);
            SntxToken textToken;
            do
            {
                textToken = lexer.nxtToken();

                if (textToken.Type != TypeOfSyntax.WhtSpToken && textToken.Type != TypeOfSyntax.NotReconToken)
                {
                    tokenList.Add(textToken);
                }

            } while (textToken.Type != TypeOfSyntax.FileEndToken);

            this.tokenList = tokenList.ToArray();
        }
        private SntxToken Peek(int offset)
        {
            var index = this.tokenPos + offset;
            if (index >= this.tokenList.Length)
            {
                return this.tokenList[this.tokenList.Length - 1];

            }
            return this.tokenList[index];
        }
            private SntxToken Current => Peek(0);
    }
    abstract class SntxNode
    {
        public abstract TypeOfSyntax Type { get; }
        //continue here
    }
}
