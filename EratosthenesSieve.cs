using System.Collections.Generic;
using System.Linq;

namespace PrimeFactors
{
    public class EratosthenesSieve
    {
        public static List<int> FindPrimes(int number)
        {
            var list = Enumerable.Range(2, number - 2 + 1);
           return GetFactors(number, Sieve(list, 2));
        }

        public static IEnumerable<int> Sieve(IEnumerable<int> possiblePrimes, int start)
        {
            var newList = possiblePrimes.Where(x => x % start != 0 || x < 2 * start);
            if (start == newList.Last())
            {
                return newList;
            }

            return Sieve(newList, newList.SkipWhile(x => x <= start).First());
        }

        public static List<int> GetFactors(int number, IEnumerable<int> potentialFactors)
        {
            return potentialFactors.Where(x => number % x == 0).ToList();
        }
    }
}
