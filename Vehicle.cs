using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInheritance
{
    abstract class Vehicle
    {
        public string RegistrationNumber { get; }

        public string Brand { get; }

        public string Model { get; }

        public FuelType FuelType { get; }
        public ushort Velocity { get; protected set; }

        public Vehicle(string registrationNumber, string brand, string model, FuelType fuelType)
        {
            RegistrationNumber = registrationNumber;
            Brand = brand;
            Model = model;
            FuelType = FuelType;
        }

        public abstract void Accelerate();

        public abstract void Break();
    }
}
