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
            naturalNumber = DivideOut(naturalNumber, 2, factors);
            if (naturalNumber < 2) {
                return factors;
            }
            factors.Add(naturalNumber);
            return factors;
        }

        private int DivideOut(int naturalNumber, int divisor, List<int> factors) {
            if (naturalNumber % divisor == 0) {
                factors.Add(divisor);
                naturalNumber /= divisor;
            }
            return naturalNumber;
        }
    }
}
