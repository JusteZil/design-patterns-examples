namespace DesignPatterns.Visitor
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
