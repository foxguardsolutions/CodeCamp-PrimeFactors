using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PrimeFactors.tests
{
    [TestFixture]
    public class PrimeFactorsTests {
        [TestCaseSource(typeof(TestCaseFactory), nameof(TestCaseFactory.FindFactorsTestCases))]
        public void FindFactors_ReturnsList(int naturalNumber, int[] resultArray) {
            var factorFinder = new Finder();
            var resultList = new List<int>(resultArray);
            Assert.That(factorFinder.FindFactors(naturalNumber), Is.EqualTo(resultList));
        }
    }
    public class TestCaseFactory {
        public static IEnumerable<TestCaseData> FindFactorsTestCases {
            get {
                yield return new TestCaseData(1, new int[0]);
                yield return new TestCaseData(2, new int[] { 2 });
                yield return new TestCaseData(3, new int[] { 3 });
                yield return new TestCaseData(4, new int[] { 2, 2 });

            }
        }
    }
}
