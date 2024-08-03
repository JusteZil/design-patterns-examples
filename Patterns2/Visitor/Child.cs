namespace Patterns2.Visitor
{
    public class Child : Client
    {
        public Child(string name) : base(name)
        {
        }

        public override double GetInsuranceCost(IInsurer insurance)
        {
            return insurance.CalculateInsurance(this);
        }
    }
}
