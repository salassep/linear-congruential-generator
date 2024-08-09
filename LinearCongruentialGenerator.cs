using linear_congruential_generator.Utils;

namespace linear_congruential_generator 
{
    /// <summary>
    /// Randomizes a list of items using the Linear Congruential Method (LCM).
    /// </summary>
    public class LinearCongruentialGenerator
    {
        private int _seed;
        private int _a;
        private int _c;
        private int _m;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearCongruentialGenerator"/> class.
        /// </summary>
        /// <param name="seed">Optional. The seed value for the random number generator. If not provided, defaults to the current system tick count.</param>
        public LinearCongruentialGenerator(int? seed = null)
        {
            _seed = seed ?? (int)DateTime.Now.Ticks % int.MaxValue;
        }

        /// <summary>
        /// Generates the random index number using the LCM formula.
        /// </summary>
        /// <param name="xn">The current xn value.</param>
        /// <returns>The random index number in the sequence.</returns>
        private int GetRandomIndex(int xn)
        {
            return (_a * xn + _c) % _m;
        }

        /// <summary>
        /// Randomizes the specified list using the Linear Congruential Method.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="data">The list of items to randomize.</param>
        /// <returns>A new list with the elements in a randomized order.</returns>
        public List<T> Randomize<T>(List<T> data)
        {
            List<T> randomizedList = new List<T>(data);
            int randomIndex = _seed;

            _m = data.Count;
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
