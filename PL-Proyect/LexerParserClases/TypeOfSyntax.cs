namespace PL_Proyect.LexerParserClases
{
    public enum TypeOfSyntax
    {
        //token list
        NotReconToken,
        FileEndToken,
        NumToken,
        WhtSpToken,
        SumToken,
        SubToken,
        DivToken,
        MultToken,
        LftParToken,
        RgtParToken,

        //??
        EqToken,

        //Expressions list
        EvalNumber,
        BinaryEvaluator,
        ParenExpressSntx
    }
}
