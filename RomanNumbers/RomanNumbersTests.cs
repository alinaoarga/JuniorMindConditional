using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumbers
{
    [TestClass]
    public class RomanNumbersTests
    {
        string[] roman = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        string[] tenth = { "X", "XX", "XXX" };
        [TestMethod]
        public void FirstConvertTest()
        {
            Assert.AreEqual("I", ConvertToRoman(1));
        }


        [TestMethod]
        public void SecondConvertTest()
        {
            Assert.AreEqual("II", ConvertToRoman(2));
        }
        [TestMethod]
        public void ThirdConvertTest()
        {
            Assert.AreEqual("III", ConvertToRoman(3));
        }
        [TestMethod]
        public void TenConvertTest()
        {
            Assert.AreEqual("X", ConvertToRoman(10));
        }
        [TestMethod]
        public void ElevenConvertTest()
        {
            Assert.AreEqual("XI", ConvertToRoman(11));
        }
        [TestMethod]
        public void TwelveConvertTest()
        {
            Assert.AreEqual("XII", ConvertToRoman(12));
        }
        [TestMethod]
        public void ThirtyFiveTest()
        {
            Assert.AreEqual("XXXV", ConvertToRoman(35));
        }
        string ConvertToRoman(int number)
        {
            if (number <= 9)
            {
                return roman[number - 1];
            }
            else if (number == 10)
            {
                return tenth[0];
            }
            else
            {
                int nrOfTens = number / 10;
                int nrOfRoman = number - nrOfTens * 10;
                string finalNumber = tenth[nrOfTens - 1] + roman[nrOfRoman - 1];
                return finalNumber;
            }
        }

    }
}





