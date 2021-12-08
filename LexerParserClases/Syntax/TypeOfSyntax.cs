namespace BabyCsharpProject.LexerParserClases.Syntax
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
        IdentifierToken,
        NegationToken,
        LogicANDToken,
        LogicORToken,

        //Keywords
        TrueKeyword,
        FalseKeyword,

        //??
        EqToken,

        //Expressions list
        EvalNumber,
        BinaryEvaluator,
        UnaryBinaryEvaluator,
        ParenExpressSntx,

    }
}
