using System;

namespace Patterns2.Visitor
{
    public class LietuvosInsurance : IInsurer
    {
        public double CalculateInsurance(Child child)
        {
            Console.WriteLine("Insurance for {0} (child) in Lietuvos draudimas costs: {1}", child.Name, 355);
            return 355;
        }

        public double CalculateInsurance(Adult adult)
        {
            Console.WriteLine("Insurance for {0} (adult) in Lietuvos draudimas costs: {1}", adult.Name, 730);
            return 730;
        }

        public double CalculateInsurance(Pensioner pensioner)
        {
            Console.WriteLine("Insurance for {0} (pensioner) in Lietuvos draudimas costs: {1}", pensioner.Name, 415);
            return 415;
        }
    }
}
