namespace FactoryMethod.Insurance
{
    public interface IPolicy
    {
        int PolicyId { get; }
        decimal CalcPrice();
    }
}