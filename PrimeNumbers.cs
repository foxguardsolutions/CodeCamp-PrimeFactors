using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeFactors
{
    public class PrimeNumbers
    {
        private const int _firstPrime = 2;

        public static void Main(string[] args)
        {
            var number = ParseArguments(args);
            PrintFactors(DoFactor(number), number);
        }

        public static List<int> DoFactor(int number)
        {
            return Enumerable.Range(_firstPrime, number - _firstPrime + 1).Where(x => number % x == 0).Where(IsPrime).ToList();
        }

        public static bool IsPrime(int factor)
        {
            return Enumerable.Range(_firstPrime, (int)Math.Floor(Math.Sqrt(factor)) - _firstPrime + 1).Where(x => factor % x == 0).ToArray().Length == 0;
        }

        public static int ParseArguments(string[] args)
        {
            if (args.Length != 1)
            {
                PrintUsage();
            }

            int number = 0;
            if (!int.TryParse(args[0], out number))
            {
                throw new ArgumentException(string.Format("{0} is not a valid number!", args[0]));
            }

            return number;
        }

        public static void PrintFactors(List<int> factors, int number)
        {
            Console.WriteLine("Factors of {0}:", number);
            foreach (var prime in factors)
            {
                Console.WriteLine("{0}", prime);
            }
        }

        public static void PrintUsage()
        {
            throw new ArgumentException(string.Format("Usage: {0} <uint>", AppDomain.CurrentDomain.FriendlyName));
        }
    }
}
