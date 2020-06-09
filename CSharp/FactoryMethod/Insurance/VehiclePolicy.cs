namespace FactoryMethod.Insurance
{
    public class VehiclePolicy : Policy, IVehiclePolicy
    {
        public class VehiclePolicyFactory : PolicyFactory
        {
            public override IPolicy CreatePolicy(int vehiclePolicyId)
            {
                return new VehiclePolicy(vehiclePolicyId);
            }
        }
        protected VehiclePolicy(int vehiclePolicyId) : base(vehiclePolicyId)
        {

        }

        public override decimal CalcPrice()
        {
            return 10*10;
        }
    }
}
