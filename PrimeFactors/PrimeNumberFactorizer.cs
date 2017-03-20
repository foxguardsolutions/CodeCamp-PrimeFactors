using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    public class PrimeNumberFactorizer
    {
        private const uint LOWEST_PRIME_NUMBER = 2;

        public IEnumerable<uint> GetPrimeFactors(uint num)
        {
            var primeFactors = new List<uint>();

            while (num >= LOWEST_PRIME_NUMBER)
            {
                primeFactors.Add(GetLowestPrimeFactor(num));
                num /= primeFactors.Last();
            }
            return primeFactors;
        }

        private uint GetLowestPrimeFactor(uint num)
        {
            var factor = LOWEST_PRIME_NUMBER;

            while (factor < num && num % factor != 0)
                factor++;

            return factor;
        }
    }
}
