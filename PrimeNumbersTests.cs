using System.Collections.Generic;
using NUnit.Framework;

namespace PrimeFactors
{
    [TestFixture]
    public class PrimeNumbersTests
    {
        [TestCase(3, true)]
        [TestCase(5, true)]
        [TestCase(13, true)]
        [TestCase(4, false)]
        [TestCase(2, true)]
        [TestCase(10, false)]
        public void IsPrimeReturnsTrueOnlyIfInputIsPrime(int number, bool isPrime)
        {
            Assert.AreEqual(isPrime, PrimeNumbers.IsPrime(number));
        }

        [Test]
        public void DoFactorReturnsOneElementForPrimeNumbers()
        {
            List<int> primes = PrimeNumbers.DoFactor(13);
            Assert.AreEqual(true, primes.Count == 1);
            Assert.Contains(13, primes);
        }

        [Test]
        public void DoFactorReturnsAllPrimeFactorsOfAnInput()
        {
            List<int> primes = PrimeNumbers.DoFactor(10);
            Assert.Contains(2, primes);
            Assert.Contains(5, primes);
            Assert.AreEqual(2, primes.Count);
        }
    }
}
