using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Interpreter.Relationship
{
    public abstract class NonTerminal : Expr
    {
        public Expr Left;
        public Expr Right;

        public NonTerminal(Expr left, Expr right)
        {
            Left = left;
            Right = right;
        }

    }
}
