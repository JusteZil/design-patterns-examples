using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Interpreter.Calculator
{
    public abstract class NonTerminalExpression : IExpression
    {
        public IExpression Left { get; set; }

        public IExpression Right { get; set; }

        public NonTerminalExpression(IExpression left, IExpression right)
        {
            Left = left;
            Right = right;
        }

        public abstract int Evaluate();
    }
}
