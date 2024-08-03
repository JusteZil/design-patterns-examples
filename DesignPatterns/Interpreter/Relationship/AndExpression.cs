namespace DesignPatterns.Interpreter.Relationship
{
    public class AndExpression : NonTerminal
    {
        public AndExpression(Expression left, Expression right) : base(left, right)
        {
        }
        public override bool Interpret(Context context)
        {
            return Left.Interpret(context) && Right.Interpret(context);
        }
    }
}
