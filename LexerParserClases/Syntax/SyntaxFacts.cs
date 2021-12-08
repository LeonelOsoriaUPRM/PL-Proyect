using System;

namespace BabyCsharpProject.LexerParserClases.Syntax
{
    internal static class SyntaxFacts
    {
        public static int GetBinOpPrecedence(this TypeOfSyntax Type)
        {
            switch (Type)
            {
                case TypeOfSyntax.SumToken:
                case TypeOfSyntax.SubToken:
                    return 3;
                case TypeOfSyntax.LogicANDToken:
                    return 2;
                case TypeOfSyntax.LogicORToken:
                    return 1;
                case TypeOfSyntax.MultToken:
                case TypeOfSyntax.DivToken:
                    return 4;
                default:
                    return 0;

            }


        }
        public static int GetUnaryBinOpPrecedence(this TypeOfSyntax Type)
        {
            switch (Type)
            {
                case TypeOfSyntax.SumToken:
                case TypeOfSyntax.SubToken:
                case TypeOfSyntax.NegationToken:
                    return 5;
                default:
                    return 0;

            }


        }

        public static TypeOfSyntax GetKeywordKind(string textString)
        {
            switch (textString)
            {
                case "true":
                    return TypeOfSyntax.TrueKeyword;
                case "false":
                    return TypeOfSyntax.FalseKeyword;
                default:
                    return TypeOfSyntax.IdentifierToken;
            }
        }
    }
}
