using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors {
    class Program {
        static void Main(string[] args) {
            Finder factorFinder = new Finder();
            foreach (string arg in args) {
                factorFinder.Start(arg);
            }
        }
    }
}
