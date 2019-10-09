namespace VehicleInheritance
{
    class MobileCrane
    {
        public string RegistrationNumber { get; }

        public string Brand { get; }

        public string Model { get; }

        public FuelType FuelType { get; }

        public CarType CarType { get; }

        public ushort Velocity { get; private set; }

        public ushort LiftCapacity { get; }
        private bool isLifting;

        public MobileCrane(string registrationNumber, string brand, string model, FuelType fuelType, ushort liftCapacity)
        {
            RegistrationNumber = registrationNumber;
            Brand = brand;
            Model = model;
            FuelType = fuelType;
            LiftCapacity = liftCapacity;
        }


        public void Accelerate()
        {
            Velocity += 5;
        }

        public void Break()
        {
            Velocity -= 5;
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
