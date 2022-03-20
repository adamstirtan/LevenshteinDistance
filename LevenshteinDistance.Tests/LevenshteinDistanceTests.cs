using Microsoft.VisualStudio.TestTools.UnitTesting;

using LevenshteinDistance.Core;

namespace LevenshteinDistance.Tests
{
    [TestClass]
    public class LevenshteinDistanceTests
    {
        [TestMethod]
        public void CanadaComparedToBanana_ExpectedDistance()
        {
            string s1 = "Canada";
            string s2 = "banana";

            const int expectedResult = 2;

            int result = Calculator.Compute(s1, s2);

            Assert.AreEqual(expectedResult, result);
        }
    }
}