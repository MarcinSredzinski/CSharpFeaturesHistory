namespace CSharp10Features
{
    internal struct Vegetable
    {
        //You can now have parameterless constructor
        public Vegetable()
        {
            Weight = 0;
        }

        public Vegetable(int weight)
        {
            Weight = weight;
        }

        public int Weight { get; init; }
    }
}
