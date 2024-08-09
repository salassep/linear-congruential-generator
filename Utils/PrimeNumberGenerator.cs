namespace linear_congruential_generator.Utils
{

    /// <summary>
    /// Provides methods for generating prime numbers.
    /// </summary>
    public class PrimeNumberGenerator
    {
        private static Random _random = new Random();

        /// <summary>
        /// Gets a random prime number between the specified minimum and maximum values.
        /// </summary>
        /// <param name="min">The minimum value for the prime number.</param>
        /// <param name="max">The maximum value for the prime number.</param>
        /// <returns>A random prime number between <paramref name="min"/> and <paramref name="max"/>.</returns>
        public static int GetRandomPrime(int min, int max)
        {
            List<int> primes = Enumerable.Range(min, max - min)
                .Where(IsPrime)
                .ToList();

            return primes[_random.Next(primes.Count)];
        }

        /// <summary>
        /// Determines whether the specified number is prime.
        /// </summary>
        /// <param name="number">The number to check for primality.</param>
        /// <returns><c>true</c> if the number is prime; otherwise, <c>false</c>.</returns>

        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
    
};