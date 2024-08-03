namespace DesignPatterns.Interpreter.Calculator
{
    public class SubtractionExpression : NonTerminalExpression
    {
        public SubtractionExpression(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override int Evaluate()
        {
            return Left.Evaluate() - Right.Evaluate();
        }
    }
}
