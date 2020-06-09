using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Insurance
{
    public class LifePolicy : Policy, ILifePolicy
    {
        public class LifePolicyFactory : PolicyFactory
        {
            public override IPolicy CreatePolicy(int lifePolicyId)
            {
                return new LifePolicy(lifePolicyId);
            }
        }
        protected LifePolicy(int lifePolicyId) : base(lifePolicyId)
        {

        }
        public override decimal CalcPrice()
        {
            return 30 * 2;
        }
    }
}
