using System;
namespace Vehicles
{
    public class Car: Vehicle
    {
        public Car(string make, string model, int numberOfPassengers, PowerType powerType) : base(make + " " + model, numberOfPassengers, powerType)
        {
        }
    }
}
