using System;
using System.Linq;

namespace PrimeFactors {
    public class Reporter {
        private const string SUCCESSREPORT = "Prime factorization of {0}:\n{1}";
        private const string FAILREPORT = "Could not parse \"{0}\" to an int.";

        public void Report(string integerCandidate) {
            int naturalNumber;
            if (int.TryParse(integerCandidate, out naturalNumber)) {
                ReportFactors(naturalNumber);
            } else {
                ReportInvalidInput(integerCandidate);
            }
        }

        private void ReportFactors(int naturalNumber) {
            var factorFinder = new Finder();
            var results = factorFinder.FindFactors(naturalNumber);
            var resultString = string.Join(", ", results);
            Console.WriteLine(SUCCESSREPORT, naturalNumber, resultString);
        }

        private void ReportInvalidInput(string nonInteger) {
            Console.WriteLine(FAILREPORT, nonInteger);
        }
    }
}
