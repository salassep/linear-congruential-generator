using linear_congruential_generator.Utils;

namespace linear_congruential_generator 
{
    public class LinearCongruentialGenerator
    {
        private int _seed;
        private int _a;
        private int _c;
        private int _m;

        public LinearCongruentialGenerator(int seed)
        {
            _seed = seed;
        }

        private int GetRandomIndex(int xn)
        {
            return (_a * xn + _c) % _m;
        }

        public List<T> Randomize<T>(List<T> list)
        {
            List<T> randomizedList = new List<T>(list);
            int randomIndex = _seed;

            _m = list.Count;
            _a = PrimeNumberGenerator.GetRandomPrime(1, _m);
            _c = PrimeNumberGenerator.GetRandomPrime(1, _m);

            for (int i = 0; i < _m; i++)
            {
                randomIndex = GetRandomIndex(randomIndex);
                // Swap elements
                T temp = randomizedList[i];
                randomizedList[i] = randomizedList[randomIndex];
                randomizedList[randomIndex] = temp;
            }

            return randomizedList;
        }
    }

}
