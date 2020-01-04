using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Visitor
{
    public class ErgoInsurance : IInsurer
    {
        public double CalculateInsurance(Child child)
        {
            Console.WriteLine("Insurance for {0} (child) in ERGO costs: {1}", child.Name, 325);
            return 325;
        }

        public double CalculateInsurance(Adult adult)
        {
            Console.WriteLine("Insurance for {0} (adult) in ERGO costs: {1}", adult.Name, 755);
            return 755;
        }

        public double CalculateInsurance(Pensioner pensioner)
        {
            Console.WriteLine("Insurance for {0} (pensioner) in ERGO costs: {1}", pensioner.Name, 435);
            return 435;
        }
    }
}
