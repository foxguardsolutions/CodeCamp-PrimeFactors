using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors {
    public class Finder {
        private const int LOWESTPRIME = 2;
        internal void Start(string arg) {
            throw new NotImplementedException();
        }

        public List<int> FindFactors(int naturalNumber) {
            var factors = new List<int>();
            if (naturalNumber < LOWESTPRIME) {
                return factors;
            }
            naturalNumber = DivideOutAll(naturalNumber, 2, factors);
            naturalNumber = DivideOutAll(naturalNumber, 3, factors);
            if (naturalNumber < LOWESTPRIME) {
                return factors;
            }
            factors.Add(naturalNumber);
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
