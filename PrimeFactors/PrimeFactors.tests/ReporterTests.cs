using System;
using System.IO;
using System.Collections.Generic;
using NUnit.Framework;

namespace PrimeFactors.tests {
    [TestFixture]
    public class ReporterTests {
        [TestCaseSource(nameof(ReportTestCases))]
        public void Report_WritesToConsole(string integerCandidate, string expectedReport) {
            var factorReporter = new Reporter();
            var actualReport = ReportConsoleOutputToString(factorReporter, integerCandidate);
            Assert.That(actualReport, Is.EqualTo(expectedReport));
        }

        private string ReportConsoleOutputToString(Reporter factorReporter, string integerCandidate) {
            using (StringWriter consoleWriter = new StringWriter()) {
                Console.SetOut(consoleWriter);
                factorReporter.Report(integerCandidate);
                return consoleWriter.ToString();
            }
        }

        private static IEnumerable<TestCaseData> ReportTestCases() {
            yield return new TestCaseData("4", "Prime factorization of 4:\n2, 2" + Environment.NewLine);
            yield return new TestCaseData("-1", "Prime factorization of -1:\n" + Environment.NewLine);
            yield return new TestCaseData("2.5", "Could not parse \"2.5\" to an int." + Environment.NewLine);
            yield return new TestCaseData("Hello!", "Could not parse \"Hello!\" to an int." + Environment.NewLine);
        }
    }
    
}
