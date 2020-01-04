using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Interpreter.Calculator
{
    public interface IExpression
    {
        public abstract int Evaluate();
    }
}
