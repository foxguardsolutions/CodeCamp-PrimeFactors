using System.Collections.Generic;

namespace PrimeFactors {
    public class Finder {
        private const int LOWESTPRIME = 2;

        public List<int> FindFactors(int naturalNumber) {
            var factors = new List<int>();
            for (int divisor = LOWESTPRIME; divisor <= naturalNumber; divisor++) {
                naturalNumber = DivideOutAll(naturalNumber, divisor, factors);
            }
            return factors;
        }

        private int DivideOutAll(int naturalNumber, int divisor, List<int> factors) {
            while (naturalNumber % divisor == 0) {
                naturalNumber = DivideOutOnce(naturalNumber, divisor, factors);
            }
            return naturalNumber;
        }

        private int DivideOutOnce(int naturalNumber, int divisor, List<int> factors) {
            factors.Add(divisor);
            return naturalNumber / divisor;
        }
    }
}
