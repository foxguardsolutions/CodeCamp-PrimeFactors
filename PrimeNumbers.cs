using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeFactors
{
    public class PrimeNumbers
    {
        public static void Main(string[] args)
        {
            var n = ParseArguments(args);
            PrintFactors(DoFactor(n), n);
        }

        public static List<int> DoFactor(int n)
        {
            return Enumerable.Range(2, n - 2 + 1).Where(x => n % x == 0).Where(IsPrime).ToList();
        }

        public static bool IsPrime(int factor)
        {
            return Enumerable.Range(2, factor - 2).Where(x => factor % x == 0).ToArray().Length == 0;
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
                Console.WriteLine("{0} is not a valid integer!", args[0]);
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
            Console.WriteLine("Usage: {0} <uint>", AppDomain.CurrentDomain.FriendlyName);
        }
    }
}
