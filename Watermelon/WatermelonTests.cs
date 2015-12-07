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
        [TestMethod]
        public void ThirdWatermelonTest()
        {
            Assert.AreEqual("NU", CalculatePossibility(2));

        }
        string CalculatePossibility(double WatermelonWeight)
        {
            string str1 = "DA";
            string str2 = "NU";
                if (WatermelonWeight == 2)
                {
                    return str2;
                }
                else if(WatermelonWeight % 2 == 0)
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

