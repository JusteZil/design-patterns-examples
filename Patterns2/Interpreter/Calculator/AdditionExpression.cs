namespace Patterns2.Interpreter.Calculator
{
    public class AdditionExpression : NonTerminalExpression
    {
        public AdditionExpression(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override int Evaluate()
        {
            return Left.Evaluate() + Right.Evaluate();
        }
    }
}
