using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Watermelon
{
    [TestClass]
    public class WatermelonTests
    {
        [TestMethod]
        public void FirstWatermelonTest()
        {
            Assert.AreEqual("DA", CalculatePossibility(20));

        }
        [TestMethod]
        public void SecondWatermelonTest()
        {
            Assert.AreEqual("NU", CalculatePossibility(21));

        }
        string CalculatePossibility(double WatermelonWeight)
        {
            string str1 = "DA";
            string str2 = "NU";
            return WatermelonWeight % 2 == 0 ? str1 : str2;
        }
    }
}
