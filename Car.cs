using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInheritance
{
    class Car
    {
        public string RegistrationNumber { get; }

        public string Brand { get; }

        public string Model { get; }

        public FuelType FuelType { get; }

        public CarType CarType { get; }

        public ushort Velocity { get; private set; }

        private bool isTrunkOpen;

        public Car(string registrationNumber, string brand, string model, FuelType fuelType, CarType carType)
        {
            RegistrationNumber = registrationNumber;
            Brand = brand;
            Model = model;
            FuelType = fuelType;
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
