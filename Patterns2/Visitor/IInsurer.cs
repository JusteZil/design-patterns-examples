using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Visitor
{
    public interface IInsurer
    {
        public double CalculateInsurance (Child child);
        public double CalculateInsurance(Adult adult);
        public double CalculateInsurance(Pensioner pensioner);
    }
}
