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
            factors.Add(2);
            return factors;
        }
    }
}
