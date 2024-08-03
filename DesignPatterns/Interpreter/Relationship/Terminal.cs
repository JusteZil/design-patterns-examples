namespace DesignPatterns.Interpreter.Relationship
{
    public class Terminal : Expression
    {
        public string Name;

        public Terminal(string name)
        {
            Name = name;
        }

        public override bool Interpret(Context context)
        {
            return context.Input.Contains(Name);
        }
    }
}
