namespace DesignPatterns.Interpreter.Relationship
{
    public class OrExpression : NonTerminal
    {
        public OrExpression(Expression left, Expression right) : base(left, right)
        {
        }
        public override bool Interpret(Context context)
        {
            return Left.Interpret(context) || Right.Interpret(context);
        }
    }
}
