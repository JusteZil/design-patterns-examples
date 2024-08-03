namespace Patterns2.Visitor
{
    public interface IInsurer
    {
        public double CalculateInsurance (Child child);
        public double CalculateInsurance(Adult adult);
        public double CalculateInsurance(Pensioner pensioner);
    }
}
