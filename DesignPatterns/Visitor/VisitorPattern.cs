using System;

namespace DesignPatterns.Visitor
{
    public class VisitorPattern : DesignPattern
    {
        public override string Name => "Visitor";

        public override void Run()
        {
            var child = new Child("John");
            var adult = new Adult("Marry");
            var pensioner = new Pensioner("Richard");

            IInsurer ergo = new ErgoInsurance();
            IInsurer lietuvosDraudimas = new LietuvosInsurance();

            child.GetInsuranceCost(ergo);
            child.GetInsuranceCost(lietuvosDraudimas);
            adult.GetInsuranceCost(ergo);
            adult.GetInsuranceCost(lietuvosDraudimas);
            pensioner.GetInsuranceCost(ergo);
            pensioner.GetInsuranceCost(lietuvosDraudimas);
        }
    }
}
