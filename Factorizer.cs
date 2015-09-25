using System.Collections.Generic;

namespace PrimeFactors.Src
{
    public class Factorizer
    {
        private const int FIRST_PRIME_NUMBER = 2;
        private int currentPrimeNumber = FIRST_PRIME_NUMBER;

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
            else if (number % currentPrimeNumber == 0)
            {
                number = BeginSearchForNextPrime(number);
            }
            else
            {
                currentPrimeNumber = FindNextPrimeNumber(currentPrimeNumber);
            }

            FindPrimeFactorsFor(number);
        }

        private int BeginSearchForNextPrime(int number)
        {
            primeFactors.Add(currentPrimeNumber);

            number /= currentPrimeNumber;

            currentPrimeNumber = FIRST_PRIME_NUMBER;

            return number;
        }

        public List<int> PrimeFactors()
        {
            primeFactors.Sort();

            return primeFactors;
        }

        public int FindNextPrimeNumber(int currentPrimeNumber)
        {
            while (!IsPrime(++currentPrimeNumber)) { }

            return currentPrimeNumber;
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
