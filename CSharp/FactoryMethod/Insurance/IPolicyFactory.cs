namespace FactoryMethod.Insurance
{
    public interface IPolicyFactory
    {
        IPolicy CreatePolicy(int policyId);
    }
}