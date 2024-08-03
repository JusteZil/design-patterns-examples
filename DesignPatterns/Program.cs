using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.Composite;
using DesignPatterns.Flyweighht;
using DesignPatterns.Interpreter;
using DesignPatterns.Iterator;
using DesignPatterns.Mediator;
using DesignPatterns.Memento;
using DesignPatterns.Proxy;
using DesignPatterns.State;
using DesignPatterns.TemplateMethod;
using DesignPatterns.Visitor;

namespace DesignPatterns
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
