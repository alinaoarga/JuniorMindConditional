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
            Assert.AreEqual ("DA",CalculatePossibility(20));
            
        }
        string CalculatePossibility(double WatermelonWeight)
        {
            string str1 = "DA";
            string str2 = "NU";
            if (WatermelonWeight % 2 == 0)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }
    }
}
