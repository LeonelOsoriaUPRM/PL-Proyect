namespace PL_Proyect.LexerParserClases
{
    internal static class SyntaxFacts
    {
        public static int GetBinOpPrecedence(this TypeOfSyntax Type)
        {
            switch (Type)
            {
                case TypeOfSyntax.SumToken:
                case TypeOfSyntax.SubToken:
                    return 1;
                case TypeOfSyntax.MultToken:
                case TypeOfSyntax.DivToken:
                    return 2;
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
                    return 3;
                default:
                    return 0;

            }


        }
    }
}
