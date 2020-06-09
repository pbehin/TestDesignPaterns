using FactoryMethod.Insurance;
using System;

namespace FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IPolicyFactory factory = null;
            var policyType = GetPolicyTypeFromUser();
            factory = CreatePolicyFactory(policyType);
            
            if (factory == null) return;
            
            var policy = factory.CreatePolicy(1);
            
            Console.WriteLine($"Policy Price : {policy.CalcPrice()}");
        }

        private static IPolicyFactory CreatePolicyFactory(int policyType)
        {
            IPolicyFactory factory;
            factory = policyType switch
            {
                1 => new LifePolicy.LifePolicyFactory(),
                2 => new VehiclePolicy.VehiclePolicyFactory(),
                _ => null
            };
            return factory;
        }

        private static int GetPolicyTypeFromUser()
        {
            Console.WriteLine("Please Select Policy Type : ");
            Console.WriteLine("1) Life");
            Console.WriteLine("2) Vehicle");
            return Int32.Parse(Console.ReadLine());
        }
    }
}
