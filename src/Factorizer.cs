using System.Collections.Generic;

namespace PrimeFactors.Src
{
    public class Factorizer
    {
        private const int FIRST_ODD_PRIME = 3;
        private int currentPrimeNumber = FIRST_ODD_PRIME;

        private List<int> primeFactors = new List<int>();

        public void FindPrimeFactorsFor(int number)
        {
            if (number % 2 == 0)
            {
                primeFactors.Add(2);

                number /= 2;
            }
            else if (number % currentPrimeNumber == 0)
            {
                primeFactors.Add(currentPrimeNumber);

                number /= currentPrimeNumber;

                currentPrimeNumber = FIRST_ODD_PRIME;
            }
            else
            {
                currentPrimeNumber = NextPrimeNumberAfter3(currentPrimeNumber);
            }

            if (IsPrime(number))
            {
                if (number != 1)
                {
                    primeFactors.Add(number);
                }

                return;
            }

            FindPrimeFactorsFor(number);
        }

        public List<int> PrimeFactors()
        {
            primeFactors.Sort();

            return primeFactors;
        }

        public int NextPrimeNumberAfter3(int currentPrimeNumber)
        {
            int nextPrime = currentPrimeNumber + 2;

            while (!IsPrime(nextPrime))
            {
                nextPrime += 2;
            }

            return nextPrime;
        }

        public bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
