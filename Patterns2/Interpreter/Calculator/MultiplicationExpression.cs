namespace Patterns2.Interpreter.Calculator
{
    public class MultiplicationExpression : NonTerminalExpression
    {
        public MultiplicationExpression(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override int Evaluate()
        {
            return Left.Evaluate() * Right.Evaluate();
        }
    }
}
