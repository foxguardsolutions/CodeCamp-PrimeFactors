using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors.Tests
{
    [TestFixture]
    public class PrimeNumberFactorizerTests
    {
        private PrimeNumberFactorizer _factorizer;

        [SetUp]
        public void SetUp()
        {
            _factorizer = new PrimeNumberFactorizer();
        }

        [Test]
        public void GetPrimeFactors_Given0_ReturnsEmptyList()
        {
            CollectionAssert.IsEmpty(_factorizer.GetPrimeFactors(0));
        }

        [Test]
        public void GetPrimeFactors_Given1_ReturnsEmptyList()
        {
            CollectionAssert.IsEmpty(_factorizer.GetPrimeFactors(1));
        }

        [TestCaseSource(nameof(NonPrimeNumbersAndExpectedFactors))]
        public void GetPrimeFactors_GivenNonPrimeNumber_ReturnsExpectedFactors(uint num, IEnumerable<uint> factors)
        {
            CollectionAssert.AreEqual(factors, _factorizer.GetPrimeFactors(num));
        }

        [TestCaseSource(nameof(PrimeNumbers))]
        public void GetPrimeFactors_GivenPrimeNumber_ReturnsOnlyNumberProvided(uint num)
        {
            var factors = new List<uint>();
            factors.Add(num);
            
            CollectionAssert.AreEqual(factors, _factorizer.GetPrimeFactors(num));
        }

        [TestCaseSource(nameof(PrimeNumberSquaredAndSquareRoot))]
        public void GetPrimeFactors_GivenPrimeNumberSquared_ReturnsSquareRootOfNumberDuplicated(uint num, uint sqrt)
        {
            var factors = new List<uint>();
            factors.Add(sqrt);
            factors.Add(sqrt);

            CollectionAssert.AreEqual(factors, _factorizer.GetPrimeFactors(num));
        }

        private static IEnumerable<TestCaseData> NonPrimeNumbersAndExpectedFactors()
        {
            yield return new TestCaseData(6U, new uint[] { 2, 3 });
            yield return new TestCaseData(100U, new uint[] { 2, 2, 5, 5 });
            yield return new TestCaseData(398U, new uint[] { 2, 199 });
            yield return new TestCaseData(2310U, new uint[] { 2, 3, 5, 7, 11 });
        }

        private static IEnumerable<uint> PrimeNumbers()
        {
            yield return 2;
            yield return 3;
            yield return 5;
            yield return 151;
            yield return 199;
        }

        private static IEnumerable<TestCaseData> PrimeNumberSquaredAndSquareRoot()
        {
            yield return new TestCaseData(4U, 2U);
            yield return new TestCaseData(49U, 7U);
            yield return new TestCaseData(121U, 11U);
            yield return new TestCaseData(38809U, 197U);
        }
    }
}
