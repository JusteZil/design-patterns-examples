namespace Patterns2.Interpreter.Relationship
{
    public class Context
    {
        public string Input { get; set; }
        public bool Output { get; set; }
        public Context(string input)
        {
            Input = input;
        }

        public void SetInput(string input)
        {
            Input = input;
        }
    }
}
