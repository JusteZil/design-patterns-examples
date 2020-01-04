using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Interpreter.Relationship
{
    public class AndExpression : NonTerminal
    {
        public AndExpression(Expr left, Expr right) : base(left, right)
        {
        }
        public override bool Interpret(Context context)
        {
            return Left.Interpret(context) && Right.Interpret(context);
        }
    }
}
