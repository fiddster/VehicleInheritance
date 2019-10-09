using System;
using static System.Console;

namespace VehicleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle teslaModel3 = new Car(  
                                        registrationNumber: "ABC123",
                                        brand: "Tesla",
                                        model: "Model 3",
                                        carType: CarType.Sedan
                                        );
            

        }
    }
}
