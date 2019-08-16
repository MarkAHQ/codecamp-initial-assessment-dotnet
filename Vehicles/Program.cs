using System.Collections.Generic;

namespace Vehicles
{
    class Program
    {
        private static List<Vehicle> vehicles;

        static void Main(string[] args)
        {
            vehicles = new List<Vehicle>();

            vehicles.Add(new Car("Holden", "Monaro", 4, PowerType.Petrol));
            vehicles.Add(new Car("Toyota", "Camry", 4, PowerType.Petrol));
            vehicles.Add(new Car("Porsche", "911 GT3 RS", 2, PowerType.Petrol));
            vehicles.Add(new Car("Puegeot", "308 GT", 4, PowerType.Diesel));
            vehicles.Add(new Car("Tesla", "Model 3", 4, PowerType.Electricity));
            vehicles.Add(new Bicycle("Road Bike", 1, PowerType.Self));
            vehicles.Add(new Bicycle("Electric Bicycle", 1, PowerType.Electricity));
            vehicles.Add(new Car("Tesla2", "Model 3", 4, PowerType.Electricity));

            /**
             * #1 Create a new Vehicle subclass for Skateboard then add an instance to the vehicles collection
             */


            /**
             * #2 Iterate over the vehicles and output the name of the first vehicle
		     * which can carry 3 or more passengers and does not use fossil fuel
             */


        }
    }
}
