using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sut = new DecisionsFuzzyClass.FuzzyDecisions();
            sut.SimpleRatio("A","B");
        }

        [TestMethod]
        public void TestMethod2()
        {
            var sut = new DecisionsFuzzyClass.FuzzyDecisions();
            var result = sut.ParialRatio("A","B");
        }
    }
}
