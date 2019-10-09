namespace VehicleInheritance
{
    class MobileCrane : Vehicle
    {
        
        public ushort LiftCapacity { get; }
        private bool isLifting;

        public MobileCrane(string registrationNumber, string brand, string model, FuelType fuelType, ushort liftCapacity) 
            :base(registrationNumber, brand, model, fuelType)
        {
            LiftCapacity = liftCapacity;
        }


        public override void Accelerate()
        {
            Velocity += 1;
        }

        public override void Break()
        {
            Velocity -= 1;
        }

        public void Lift()
        {
            isLifting = true;
        }

        public void Drop()
        {
            isLifting = false;
        }

    }
}
