using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    public class NumericAnalyzer
    {
        public NumericAnalyzer() { }

        public List<int> GetPrimeFactors(int num)
        {
            List<int> primeFactors = new List<int>();

            while (num >= 2)
                primeFactors.Add(RemoveLowestFactor(num, out num));

            return primeFactors;
        }

        /*************** Private Functions ***************/
        public int GetLowestFactor(int num)
        {
            int factor = 2;

            while (factor < num && num % factor != 0)
                factor++;

            return factor;
        }

        public int RemoveLowestFactor(int num, out int newNum)
        {
            int lowestFactor = GetLowestFactor(num);
            newNum = num / lowestFactor;
            return lowestFactor;
        }
    }
}
