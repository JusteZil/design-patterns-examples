namespace DesignPatterns.Interpreter.Calculator
{
    public abstract class TerminalExpression : IExpression
    {
        public abstract int Evaluate();
    }
}
