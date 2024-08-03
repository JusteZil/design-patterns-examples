using Patterns2.ChainOfResponsibility;
using Patterns2.Composite;
using Patterns2.Flyweighht;
using Patterns2.Interpreter;
using Patterns2.Iterator;
using Patterns2.Mediator;
using Patterns2.Memento;
using Patterns2.Proxy;
using Patterns2.State;
using Patterns2.TemplateMethod;
using Patterns2.Visitor;

namespace Patterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            var designPatterns = new DesignPattern[]
            {
                new ChainOrResponsibilityPattern(),
                new CompositePattern(),
                new FlyweightPattern(),
                new TemplateMethodPattern(),
                new IteratorPattern(),
                new MediatorPattern(),
                new StatePattern(),
                new ProxyPattern(),
                new InterpreterPattern(),
                new MementoPattern(),
                new VisitorPattern(),
            };

            foreach (var designPattern in designPatterns)
            {
                designPattern.RunExample();
            }
        }
    }
}
