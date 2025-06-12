namespace BehavioralPatterns.Strategy
{
    // Interface da estratégia
    public interface IShippingStrategy
    {
        decimal Calculate(decimal orderValue);
    }

}