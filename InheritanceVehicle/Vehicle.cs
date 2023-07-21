namespace InheritanceVehicle
{
    public class Vehicle
    {
        private string name;
#pragma warning disable SA1214
        private readonly int maxSpeed;
#pragma warning restore SA1214

        public Vehicle(string name, int maxSpeed)
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
        }

#pragma warning disable S2292
        protected string Name
#pragma warning restore S2292
        {
            get { return this.name; }
            set { this.name = value; }
        }

#pragma warning disable SA1202
        public int MaxSpeed
#pragma warning restore SA1202
        {
            get { return this.maxSpeed; }
        }
    }
}
