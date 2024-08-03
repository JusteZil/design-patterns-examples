namespace DesignPatterns.State
{
    public interface IDiscount
    {
        public double HandlePurchaseDiscount(double price, Client client);
    }
}
