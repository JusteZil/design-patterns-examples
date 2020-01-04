using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Interpreter.Calculator
{
    public class DivisionExpression : NonTerminalExpression
    {
        public DivisionExpression(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override int Evaluate()
        {
            if (Right.Evaluate() == 0)
                throw new DivideByZeroException();
            return Left.Evaluate() / Right.Evaluate();
        }
    }
}
