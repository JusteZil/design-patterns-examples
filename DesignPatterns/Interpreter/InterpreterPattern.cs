using DesignPatterns.Interpreter.Calculator;
using DesignPatterns.Interpreter.Relationship;
using DesignPatterns.Interpreter.Roman;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Interpreter
{
    public class InterpreterPattern : DesignPattern
    {
        public override string Name => "Interpreter";

        public override void Run()
        {
            RunRomanNumbersExample();
            RunCalculatorExample();
            RunRelationshipsExample();
        }

        private void RunRomanNumbersExample()
        {
            Console.WriteLine("Roman numbers example:");

            string roman = "MCMXXVIII";
            var context = new Roman.Context(roman);

            var tree = new List<Roman.Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            foreach (var exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine("{0} = {1}", roman, context.Output);
            Console.WriteLine();
        }

        private void RunCalculatorExample()
        {
            Console.WriteLine("Calculator example:");
            var expParser = new ExpressionParser();
            expParser.Parse("2 5 +");
            Console.WriteLine();
        }

        private void RunRelationshipsExample()
        {
            Console.WriteLine("Relationships example:");
            var person1 = new Terminal("Tom");
            var person2 = new Terminal("Luke");
            var isSingle = new OrExpression(person1, person2);

            var alice = new Terminal("Alice");
            var committed = new Terminal("Committed");
            var isCommitted = new AndExpression(alice, committed);

            var context = new Relationship.Context("Tom");
            Console.WriteLine(isSingle.Interpret(context));
            context.SetInput("Andrew");
            Console.WriteLine(isSingle.Interpret(context));

            context.SetInput("Committed, Alice");
            Console.WriteLine(isCommitted.Interpret(context));
            context.SetInput("Single, Alice");
            Console.WriteLine(isCommitted.Interpret(context));
        }
    }
}
