namespace DesignPatterns.Interpreter.Relationship
{
    public abstract class NonTerminal : Expression
    {
        public Expression Left;
        public Expression Right;

        public NonTerminal(Expression left, Expression right)
        {
            Left = left;
            Right = right;
        }
    }
}
