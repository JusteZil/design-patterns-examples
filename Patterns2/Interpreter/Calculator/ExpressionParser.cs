using System;
using System.Collections;
using System.Collections.Generic;

namespace Patterns2.Interpreter.Calculator
{
    public class ExpressionParser
    {
        private readonly Stack<IExpression> _stack = new Stack<IExpression>();
        public int Parse(string str)
        {
            string[] tokenList = str.Split(" ");
            foreach (var symbol in tokenList)
            {
                if (!ParserUtil.IsOperator(symbol))
                {
                    try
                    {
                        IExpression numberExpression = new NumberExpression(int.Parse(symbol));
                        _stack.Push(numberExpression);
                        Console.WriteLine("Pushed to stack: {0}", numberExpression.Evaluate());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        return 0;
                    }
                }
                else if (ParserUtil.IsOperator(symbol))
                {
                    try
                    {
                        IExpression firstExpression = _stack.Pop();
                        IExpression secondExpression = _stack.Pop();

                        Console.WriteLine("Popped operands {0} and {1}", firstExpression.Evaluate(),
                            secondExpression.Evaluate());
                        IExpression op = ParserUtil.GetExpressionObject(firstExpression, secondExpression, symbol);

                        Console.WriteLine("Applying Operator: {0}", op);

                        var res = op.Evaluate();
                        NumberExpression resultExpression = new NumberExpression(res);
                        _stack.Push(resultExpression);
                        Console.WriteLine("Pushed result to stack: {0}", resultExpression.Evaluate());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        return 0;
                    }
                }
            }
            int result = _stack.Pop().Evaluate();
            return result;
        }
    }
}
