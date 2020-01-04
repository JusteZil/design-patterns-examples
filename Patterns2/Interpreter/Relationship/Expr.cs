using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Interpreter.Relationship
{
    public abstract class Expr
    {
        public abstract bool Interpret(Context context);
    }
}
