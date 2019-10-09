namespace VehicleInheritance
{
    class Car : Vehicle
    {
        public CarType CarType { get; }


        private bool isTrunkOpen;

        public Car(string registrationNumber, string brand, string model, CarType carType)
                : base(registrationNumber, brand, model, FuelType.Electricity)
        {
            CarType = carType;
        }

        public void OpenTrunk()
        {
            isTrunkOpen = true;
        }

        public void CloseTrunk()
        {
            isTrunkOpen = false;
        }

        public override void Accelerate()
        {
            Velocity += 5;
        }

        public override void Break()
        {
            Velocity += 5;
        }
    }
}
