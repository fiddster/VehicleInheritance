
namespace VehicleInheritance
{
    class Truck : Vehicle
    {
        private string[] cargoHold;

        private byte nextAvailablePosition;

        public Truck(string registrationNumber, string brand, string model, FuelType fuelType, byte cargoHoldCapacaty)
            :base(registrationNumber, brand, model, fuelType)
        {
            cargoHold = new string[cargoHoldCapacaty];
        }


        public override void Accelerate()
        {
            Velocity += 2;
        }

        public override void Break()
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
