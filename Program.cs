using System;
using static System.Console;

namespace VehicleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car teslaModel3 = new Car(  
                                        registrationNumber: "ABC123",
                                        brand: "Tesla",
                                        model: "Model 3",
                                        fuelType: FuelType.Electricity, 
                                        carType: CarType.Sedan
                                        );


        }
    }
}
