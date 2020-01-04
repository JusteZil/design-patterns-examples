using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Visitor
{
    public abstract class Client
    {
        public string Name { get; set; }

        public Client(string name)
        {
            Name = name;
        }
        public abstract double GetInsuranceCost(IInsurer insurance);
    }
}
