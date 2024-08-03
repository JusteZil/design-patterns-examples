namespace DesignPatterns.Interpreter.Relationship
{
    public abstract class Expression
    {
        public abstract bool Interpret(Context context);
    }
}
