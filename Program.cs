using BabyCsharpProject.LexerParserClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lexer = BabyCsharpProject.LexerParserClases.Lexer;

namespace BabyCsharpProject
{
    internal static class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            //Console.WriteLine("Hello World, we're making a compiler baby!");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestForm());
            /*
            var showTree = false;
            while (true)
            {
                Console.Write(">");
                var line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line))

                    return;

                if (line == "#showTree")
                {
                    showTree = !showTree;
                    Console.WriteLine(showTree ? "Showing parse trees." : "Not showing parse trees.");
                    continue;
                }
                else if (line == "#clear")
                {
                    Console.Clear();
                    continue;
                }
                var sntxTree = SntxTree.Parse(line);

                if (showTree)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;

                    TreetyPrint(sntxTree.Root);

                    Console.ResetColor();
                }
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

                    Console.ResetColor();
                }
                /*
                var lexer = new Lexer(line);
                while (true)
                {
                    var stringToken = lexer.NxtToken();
                    if (stringToken.Type == TypeOfSyntax.FileEndToken)
                        break;
                    Console.Write($"{stringToken.Type}: '{stringToken.TextString} ");
                    if (stringToken.Value != null)
                        Console.WriteLine($"{stringToken.Value} ");
                    Console.WriteLine();
                }*/


        }

    }
    /*
        static void TreetyPrint(SntxNode node, string level = "", bool isLast = true)
        {
            var marker = isLast ? "|__" : "|--";
            Console.Write(level);
            Console.Write(marker);
            Console.Write(node.Type);

            if (node is SntxToken t && t.Value != null)
            {
                Console.Write(" ");
                Console.Write(t.Value);
            }


            Console.WriteLine();
            //level += "     ";
            level += isLast ? "   " : "|  ";

            var lastChild = node.GetChildren().LastOrDefault();


            foreach (var child in node.GetChildren())
                TreetyPrint(child, level, child == lastChild);
        }
    */
}