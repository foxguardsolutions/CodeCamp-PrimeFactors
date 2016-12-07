using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PrimeFactors.tests
{
    [TestFixture]
    public class PrimeFactorsTests
    {
        [Test]
        public void FindFactors_GivenOne_ReturnsEmptyList() {
            var factorFinder = new Finder();
            var emptyList = new List<int>();
            Assert.That(factorFinder.FindFactors(1), Is.EqualTo(emptyList));
        }

        [TestCaseSource(typeof(TestCaseFactory), nameof(TestCaseFactory.SingleMemberListCandidateCases))]
        public void FindFactors_ReturnsSingleMemberList(int naturalNumber) {
            var factorFinder = new Finder();
            var singleMemberList = new List<int>(new int[] { naturalNumber });
            Assert.That(factorFinder.FindFactors(naturalNumber), Is.EqualTo(singleMemberList));
        }
    }
    public class TestCaseFactory {
        public static IEnumerable<TestCaseData> SingleMemberListCandidateCases {
            get {
                yield return new TestCaseData(2);
                yield return new TestCaseData(3);
            }
        }
    }
}
