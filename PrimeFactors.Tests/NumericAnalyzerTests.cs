using PrimeFactors;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors.Tests
{
    [TestFixture]
    class NumericAnalyzerTests
    {
        NumericAnalyzer analyzer;

        [OneTimeSetUp]
        public void Init()
        {
            analyzer = new NumericAnalyzer();
        }

        [TestCase(0)]
        [TestCase(1)]
        public void TestEmptyLists(int num)
        {
            Assert.AreEqual(0, analyzer.GetPrimeFactors(num).Count);
        }

        [TestCase(6, new int[] { 2, 3 })]
        [TestCase(100, new int[] { 2, 2, 5, 5 })]
        [TestCase(2310, new int[] { 2, 3, 5, 7, 11 })]
        [TestCase(398, new int[] { 2, 199 })]
        // Squared Numbers
        [TestCase(4, new int[] { 2, 2 })]
        [TestCase(49, new int[] { 7, 7 })]
        [TestCase(121, new int[] { 11, 11 })]
        [TestCase(38809, new int[] { 197, 197 })]
        public void TestPrimeFactors(int num, int[] factors)
        {
            List<int> primeFactors = analyzer.GetPrimeFactors(num);

            Assert.AreEqual(factors.Length, primeFactors.Count);

            for (int i = 0; i < factors.Length; i++)
                Assert.AreEqual(factors[i], primeFactors[i]);
        }

        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(151)]
        [TestCase(199)]
        public void TestPrimeNumbers(int num)
        {
            List<int> primeFactors = analyzer.GetPrimeFactors(num);

            Assert.AreEqual(1, primeFactors.Count);
            Assert.AreEqual(num, primeFactors[0]);
        }
    }
}
