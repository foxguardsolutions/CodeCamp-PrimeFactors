using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors {
    public class Finder {
        internal void Start(string arg) {
            throw new NotImplementedException();
        }

        public List<int> FindFactors(int naturalNumber) {
            var factors = new List<int>();
            if (naturalNumber < 2) {
                return factors;
            }
            while (naturalNumber % 2 == 0) {
                naturalNumber = DivideOut(naturalNumber, 2, factors);
            }
            if (naturalNumber < 2) {
                return factors;
            }
            factors.Add(naturalNumber);
            return factors;
        }

        private int DivideOut(int naturalNumber, int divisor, List<int> factors) {
            factors.Add(divisor);
            return naturalNumber / divisor;
        }
    }
}
