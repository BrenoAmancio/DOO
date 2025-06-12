namespace BehavioralPatterns.Strategy
{

    public class ExpressShipping : IShippingStrategy
    {
        public decimal Calculate(decimal orderValue)
        {
            return orderValue * 0.25m;
        }
    }
}