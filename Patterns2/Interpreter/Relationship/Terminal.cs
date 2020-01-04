using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Interpreter.Relationship
{
    public class Terminal : Expr
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
