namespace Patterns2.State
{
    public interface IDiscount
    {
        public double HandlePurchaseDiscount(double price, Client client);
    }
}
