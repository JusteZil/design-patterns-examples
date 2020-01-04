using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Visitor
{
    public class Pensioner : Client
    {
        public Pensioner(string name) : base(name)
        {

        }
        public override double GetInsuranceCost(IInsurer insurance)
        {
            return insurance.CalculateInsurance(this);
        }
    }
}
