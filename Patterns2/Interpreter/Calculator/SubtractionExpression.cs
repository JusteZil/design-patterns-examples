using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Interpreter.Calculator
{
    public class SubtractionExpression : NonTerminalExpression
    {
        public SubtractionExpression(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override int Evaluate()
        {
            return Left.Evaluate() - Right.Evaluate();
        }
    }
}
