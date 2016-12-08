using System.Collections.Generic;
using NUnit.Framework;

namespace PrimeFactors.tests {
    [TestFixture]
    public class FinderTests {
        [TestCaseSource(nameof(FindFactorsTestCases))]
        public void FindFactors_ReturnsList(int naturalNumber, int[] expectedResultArray) {
            var factorFinder = new Finder();
            var expectedResultList = new List<int>(expectedResultArray);
            Assert.That(factorFinder.FindFactors(naturalNumber), Is.EqualTo(expectedResultList));
        }
        private static IEnumerable<TestCaseData> FindFactorsTestCases() {
            yield return new TestCaseData(-1, new int[0]);
            yield return new TestCaseData(0, new int[0]);
            yield return new TestCaseData(1, new int[0]);
            yield return new TestCaseData(2, new int[] { 2 });
            yield return new TestCaseData(3, new int[] { 3 });
            yield return new TestCaseData(4, new int[] { 2, 2 });
            yield return new TestCaseData(5, new int[] { 5 });
            yield return new TestCaseData(6, new int[] { 2, 3 });
            yield return new TestCaseData(7, new int[] { 7 });
            yield return new TestCaseData(8, new int[] { 2, 2, 2 });
            yield return new TestCaseData(9, new int[] { 3, 3 });
            yield return new TestCaseData(25, new int[] { 5, 5 });
            yield return new TestCaseData(44100, new int[] { 2, 2, 3, 3, 5, 5, 7, 7 });
        }
    }
}
