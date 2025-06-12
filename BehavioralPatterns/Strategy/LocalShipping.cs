namespace BehavioralPatterns.Strategy
{

    public class LocalShipping : IShippingStrategy
    {
        public decimal Calculate(decimal orderValue)
        {
            return orderValue * 0.05m;
        }
    }
}