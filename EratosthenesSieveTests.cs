using System.Linq;
using NUnit.Framework;

namespace PrimeFactors
{
    [TestFixture]
    public class EratosthenesSieveTests
    {
        [Test]
        public void GetFactorsReturnsAllFactorsFromOfNumberFromPotentialFactors()
        {
            var factors = EratosthenesSieve.GetFactors(10, Enumerable.Range(1, 10));
            Assert.Contains(1, factors);
            Assert.Contains(2, factors);
            Assert.Contains(5, factors);
            Assert.Contains(10, factors);
            Assert.AreEqual(4, factors.Count);
        }

        [Test]
        public void SieveReturnsOnlyPrimeNumbersFromPossiblePrimes()
        {
            var possiblePrimes = Enumerable.Range(2, 9);
            var primes = EratosthenesSieve.Sieve(possiblePrimes, 2).ToList();
            Assert.Contains(2, primes);
            Assert.Contains(3, primes);
            Assert.Contains(5, primes);
            Assert.Contains(7, primes);
            Assert.AreEqual(4, primes.Count);
        }

        [Test]
        public void FindPrimesReturnsOnlyPrimeFactorsOfAGivenNumber()
        {
            var primes = EratosthenesSieve.FindPrimes(10);
            Assert.Contains(2, primes);
            Assert.Contains(5, primes);
            Assert.AreEqual(2, primes.Count);
        }
    }
}
