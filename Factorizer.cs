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
            if (number < 2)
            {
                return;
            }
            else if (IsPrime(number))
            {
                primeFactors.Add(number);

                return;
            }
            else if (number % 2 == 0)
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

            FindPrimeFactorsFor(number);
        }

        public List<int> PrimeFactors()
        {
            primeFactors.Sort();

            return primeFactors;
        }

        public int NextPrimeNumberAfter3(int currentPrimeNumber)
        {
            if (currentPrimeNumber < 3)
            {
                return 3;
            }

            int nextPrime = currentPrimeNumber + 2;

            while (!IsPrime(nextPrime))
            {
                nextPrime += 2;
            }

            return nextPrime;
        }

        public bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

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
