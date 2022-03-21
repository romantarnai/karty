namespace VokoBere.Services
{
    public class Randomizer : IRandomizer
    {
        private Random _random = new Random();

        public int Generate(int range = 10)
        {
            return _random.Next(range);
        }
    }
}
