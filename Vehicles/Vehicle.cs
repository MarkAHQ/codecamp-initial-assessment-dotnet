namespace Vehicles
{
    public abstract class Vehicle
    {
        private string name;
        private int numberOfPassengers;
        private PowerType powerType;

        public Vehicle(string name, int numberOfPassengers, PowerType powerType)
        {
            this.Name = name;
            this.NumberOfPassengers = numberOfPassengers;
            this.PowerType = powerType;
        }

        public string Name { get => name; set => name = value; }
        public int NumberOfPassengers { get => numberOfPassengers; set => numberOfPassengers = value; }
        public PowerType PowerType { get => powerType; set => powerType = value; }

        public bool usesFossilFuel()
        {
            return this.powerType == PowerType.Petrol || this.powerType == PowerType.Diesel;
        }
    }
}
