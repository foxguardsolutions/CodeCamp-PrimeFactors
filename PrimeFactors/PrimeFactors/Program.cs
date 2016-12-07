namespace PrimeFactors {
    class Program {
        static void Main(string[] args) {
            var factorReporter = new Reporter();
            foreach (string arg in args) {
                factorReporter.Report(arg);
            }
        }
    }
}
