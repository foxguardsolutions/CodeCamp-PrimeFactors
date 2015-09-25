using System;
using System.Collections.Generic;
using PrimeFactors.Src;

namespace PrimeFactors.Test
{
    using NUnit.Framework;

    [TestFixture]
    public class FactorizerTest
    {
        [TestCase(1, new int[] {})]
        [TestCase(2, new int[] { 2 })]
        [TestCase(3, new int[] { 3 })]
        [TestCase(22, new int[] { 2, 11 })]
        [TestCase(74, new int[] { 2, 37 })]
        [TestCase(90, new int[] { 2, 3, 3, 5 })]
        [TestCase(9999, new int[] {3, 3, 11, 101 })]
        [TestCase(360, new int[] { 2, 2, 2, 3, 3, 5 })]
        public void TestFactoization(int numberToTest, int[] primeFactors)
        {
            Factorizer factorizer = new Factorizer();

            factorizer.FindPrimeFactorsFor(numberToTest);

            List<int> result = factorizer.PrimeFactors();

            int[] primeFactorsArray = result.ToArray();

            Assert.AreEqual(primeFactors, primeFactorsArray);
        }

        [TestCase(1, 3)]
        [TestCase(3, 5)]
        [TestCase(5, 7)]
        [TestCase(7, 11)]
        [TestCase(11, 13)]
        [TestCase(823, 827)]
        public void TestNextPrimeNumberAfter3(int prime, int nextPrime)
        {
            Factorizer factorizer = new Factorizer();

            int nextPrimeResult = factorizer.NextPrimeNumberAfter3(prime);

            Assert.AreEqual(nextPrime, nextPrimeResult);
        }

        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(25, false)]
        public void TestIsPrime(int numberToTest, bool isPrime)
        {
            Factorizer factorizer = new Factorizer();

            bool isPrimeResult = factorizer.IsPrime(numberToTest);

            Assert.AreEqual(isPrime, isPrimeResult);
        }
    }
}
