using Microsoft.VisualStudio.TestTools.UnitTesting;

using LevenshteinDistance.Core;

namespace LevenshteinDistance.Tests
{
    [TestClass]
    public class LevenshteinDistanceTests
    {
        [TestMethod]
        public void CanadaComparedToBanana()
        {
            string s1 = "Canada";
            string s2 = "banana";

            const int expectedResult = 2;

            int result = Calculator.Compute(s1, s2);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void S1LessThanS2()
        {
            string s1 = "abc";
            string s2 = "abcdefgh";

            const int expectedResult = 5;

            int result = Calculator.Compute(s1, s2);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void S1GreaterThanS2()
        {
            string s1 = "abcdefgh";
            string s2 = "abc";

            const int expectedResult = 5;

            int result = Calculator.Compute(s1, s2);

            Assert.AreEqual(expectedResult, result);
        }
    }
}