using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Text;

namespace Patterns2.Interpreter.Calculator
{
    public abstract class TerminalExpression : IExpression
    {
        public abstract int Evaluate();
    }
}
