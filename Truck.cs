
namespace VehicleInheritance
{
    class Truck
    {
        public string RegistrationNumber { get; }

        public string Brand { get; }

        public string Model { get; }

        public FuelType FuelType { get; }

        public ushort Velocity { get; private set; }

        private string[] cargoHold;

        private byte nextAvailablePosition;

        public Truck(string registrationNumber, string brand, string model, FuelType fuelType, byte cargoHoldCapacaty)
        {
            RegistrationNumber = registrationNumber;
            Brand = brand;
            Model = model;
            FuelType = fuelType;
            cargoHold = new string[cargoHoldCapacaty];
        }


        public void Accelerate()
        {
            Velocity += 2;
        }

        public void Break()
        {
            Velocity -= 2;
        }

        public void Load(string cargo)
        {
            cargoHold[nextAvailablePosition++] = cargo;
        }

        public string Unload()
        {
            string toReturn = cargoHold[--nextAvailablePosition];
            
            cargoHold[nextAvailablePosition] = null;

            return toReturn;
        }

    }
}
