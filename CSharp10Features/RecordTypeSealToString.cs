namespace CSharp10Features
{
     internal record Vehicle(int Mass, int MaxSpeed)
    {        
        public sealed override string ToString()
        {
            return $"Mass of the vehicle is: {Mass} and max speed is {MaxSpeed}";
        }
    }

    internal record Bike : Vehicle
    {
        protected Bike(int Mass) : base(Mass, 0)
        {
        }
        //And now it cannot be overriden here. 
        //public override string ToString()
        //{
        //    return $"Mass of the bike is: {Mass} and the speed depends on the person riding the bike";
        //}
    }
}
