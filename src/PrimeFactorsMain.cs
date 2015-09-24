using System;
using System.Collections.Generic;
using PrimeFactors.Src;

namespace PrimeFactors
{
    public class PrimeFactorsMain
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Number to Factorize:");

                string number = Console.ReadLine();

                Factorizer factorizer = new Factorizer();

                factorizer.FindPrimeFactorsFor(int.Parse(number));

                List<int> primeFactors = factorizer.PrimeFactors();

                Console.WriteLine("Ordered Prime Factors:");

                foreach (int prime in primeFactors)
                {
                    Console.WriteLine("    " + prime);
                }
            }
        }
    }
}
