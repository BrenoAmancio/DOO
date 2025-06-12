namespace BehavioralPatterns.Strategy
{
    // Estratégias concretas
    public class EconomyShipping : IShippingStrategy
    {
        public decimal Calculate(decimal orderValue)
        {
            return orderValue * 0.10m;
        }
    }
}