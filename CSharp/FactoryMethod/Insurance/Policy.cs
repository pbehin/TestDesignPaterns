using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Insurance
{
    public abstract class Policy : IPolicy
    {
        public abstract class PolicyFactory : IPolicyFactory
        {
            public abstract IPolicy CreatePolicy(int policyId);
        }

        protected Policy(int policyId)
        {
            PolicyId = policyId;
        }
        public int PolicyId { get; }

        public abstract decimal CalcPrice();
    }
}
