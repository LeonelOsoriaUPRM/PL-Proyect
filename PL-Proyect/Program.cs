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

                var parser = new Parser(line);
                var sntxTree = parser.Parse();

                var color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkBlue;

                    TreetyPrint(sntxTree.Root);

                Console.ForegroundColor = color;

                if (!sntxTree.Diagnostics.Any())
                {
                    var eval = new Evaluator(sntxTree.Root);
                    var result = eval.Evaluate();
                    Console.WriteLine(result);
                   
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    foreach (var diag in sntxTree.Diagnostics)
                        Console.Write(diag);

                    Console.ForegroundColor = color;
                }
                /*
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
                }*/
                

            /*}*/

        }

        static void TreetyPrint(SntxNode node, string level = "", bool isLast = true)
        {
            var marker = isLast ? "|__" : "|--";
            Console.Write(level);
            Console.Write(marker);
            Console.Write(node.Type);

            if(node is SntxToken t && t.Value != null)
            {
                Console.Write(" ");
                Console.Write(t.Value);
            }


            Console.WriteLine();
            //level += "     ";
            level += isLast ? "   " : "|  ";

            var lastChild= node.GetChildren().LastOrDefault();
            

            foreach (var child in node.GetChildren())
                TreetyPrint(child, level, child == lastChild);
        }
    }


    class Lexer
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
                if(!int.TryParse(textString, out var value)){
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
        EqToken,
        EvalNumber,
        BinaryEvaluator
    }
    class SntxToken : SntxNode
    {
        public SntxToken(TypeOfSyntax type, int position, string textString, object value)
        {
            Type = type;
            Position = position;
            TextString = textString;
            Value = value;
        }

        public override TypeOfSyntax Type { get; }
        public int Position { get; }
        public string TextString { get; }
        public object Value { get; }

        public override IEnumerable<SntxNode> GetChildren()
        {
            return Enumerable.Empty<SntxNode>();
        }
    }
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
            if(CurrentP.Type == Type)
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

            while ( CurrentP.Type == TypeOfSyntax.MultToken || CurrentP.Type == TypeOfSyntax.DivToken)
            {
                var opToken = NextToken();
                var rightSyn = FirstExpEval();
                leftSyn = new EvalSyntxBinary(leftSyn, opToken, rightSyn);
            }
            return leftSyn;
        }



        private EvalSyntax FirstExpEval()
        {
            var numToken = Match(TypeOfSyntax.NumToken);
            return new NumEvalSyntx(numToken);
        }
    }
    abstract class SntxNode
    {
        public abstract TypeOfSyntax Type { get; }

        public abstract IEnumerable<SntxNode> GetChildren();

    }

    abstract class EvalSyntax : SntxNode
    {
        //somthing will go here
    }

    sealed class NumEvalSyntx : EvalSyntax
    {
        public NumEvalSyntx(SntxToken numToken)
        {
            NumToken = numToken;
            //something will go here later
        }

        public override TypeOfSyntax Type => TypeOfSyntax.EvalNumber;
        public SntxToken NumToken { get; }

        public override IEnumerable<SntxNode> GetChildren()
        {
            yield return NumToken;
        }
    }

    sealed class EvalSyntxBinary : EvalSyntax
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

    sealed class SntxTree
    {
        public SntxTree(IEnumerable<string> diagnostics, EvalSyntax root, SntxToken FileEndToken)
        {
            Diagnostics = diagnostics.ToArray();
            Root = root;
            this.FileEndToken = FileEndToken;
        }

        public IReadOnlyList<string> Diagnostics { get; }
        public EvalSyntax Root { get; }
        public SntxToken FileEndToken { get; }
    }
    class Evaluator
    {
        private readonly EvalSyntax root;
        public Evaluator( EvalSyntax root)
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
            if(node is NumEvalSyntx n)
            {
                return (int)n.NumToken.Value;
            }
            if(node is EvalSyntxBinary b)
            {
                var left = EvaluateExpress(b.LeftSyn);
                var right = EvaluateExpress(b.RightSyn);
                if(b.Evaluator.Type == TypeOfSyntax.SumToken)
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
            throw new Exception($"Unexpected node {node.Type}");

        }
    }
}
