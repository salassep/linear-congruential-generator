namespace linear_congruential_generator.Utils
{
    public class PrimeNumberGenerator
    {
        private static Random _random = new Random();

        public static int GetRandomPrime(int min, int max)
        {
            List<int> primes = Enumerable.Range(min, max - min)
                .Where(IsPrime)
                .ToList();

            return primes[_random.Next(primes.Count)];
        }

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