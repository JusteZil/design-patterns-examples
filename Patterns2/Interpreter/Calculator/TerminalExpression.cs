namespace Patterns2.Interpreter.Calculator
{
    public abstract class TerminalExpression : IExpression
    {
        public abstract int Evaluate();
    }
}
