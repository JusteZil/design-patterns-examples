using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Interpreter.Calculator
{
    public static class ParserUtil
    {
        public static bool IsOperator(string symbol)
        {
            return (symbol.Equals("+") || symbol.Equals("-") || symbol.Equals("*") || symbol.Equals("/"));
        }
        public static IExpression GetExpressionObject(IExpression firstExpression, IExpression secondExpression, string symbol)
        {
            switch(symbol)
            {
                case "+":
                    return new AdditionExpression(firstExpression, secondExpression);
                case "-":
                    return new SubtractionExpression(firstExpression, secondExpression);
                case "*":
                    return new MultiplicationExpression(firstExpression, secondExpression);
                default:
                    return new DivisionExpression(firstExpression, secondExpression);
            }
        }
    }
}
