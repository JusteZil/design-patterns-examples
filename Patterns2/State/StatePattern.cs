namespace Patterns2.State
{
    public class StatePattern : DesignPattern
    {
        public override string Name => "State";

        public override void Run()
        {
            var client = new Client("John Smith", 200);
            client.Purchase(5);
            client.Purchase(5);
            client.Purchase(10);
            client.Purchase(20);
            client.Purchase(40);
            client.Purchase(5);
            client.Purchase(5);
            client.Purchase(20);
        }
    }
}
