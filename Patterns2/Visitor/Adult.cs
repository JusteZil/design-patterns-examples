namespace Patterns2.Visitor
{
    public class Adult : Client
    {
        public Adult(string name) : base(name)
        {
        }

        public override double GetInsuranceCost(IInsurer insurance)
        {
            return insurance.CalculateInsurance(this);
        }
    }
}
