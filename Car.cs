namespace VehicleInheritance
{
    class Car : Vehicle
    {
        public CarType CarType { get; }


        private bool isTrunkOpen;

        public Car(string registrationNumber, string brand, string model, FuelType fuelType, CarType carType)
                : base(registrationNumber, brand, model, fuelType)
        {
            CarType = carType;
        }


        public void Accelerate()
        {
            Velocity += 5;
        }

        public void Break()
        {
            Velocity -= 5;
        }

        public void OpenTrunk()
        {
            isTrunkOpen = true;
        }

        public void CloseTrunk()
        {
            isTrunkOpen = false;
        }
    }
}
