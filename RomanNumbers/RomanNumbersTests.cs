using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumbers
{
    [TestClass]
    public class RomanNumbersTests
    {
        string[] roman = { " ", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        string[] tenth = { " ", "X", "XX", "XXX" };
        string[] forty = { " ", "XL", "L", "XC", "C" };
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
        [TestMethod]
        public void FortyTest()
        {
            Assert.AreEqual("XL", ConvertToRoman(40));
        }
        [TestMethod]
        public void FortyFiveTest()
        {
            Assert.AreEqual("XLV", ConvertToRoman(45));
        }
        [TestMethod]
        public void FiftyTest()
        {
            Assert.AreEqual("L", ConvertToRoman(50));
        }
        [TestMethod]
        public void FiftyFiveTest()
        {
            Assert.AreEqual("LV", ConvertToRoman(55));
        }
        [TestMethod]
        public void SixtyTest()
        {
            Assert.AreEqual("LX", ConvertToRoman(60));
        }
        [TestMethod]
        public void SixtyOneTest()
        {
            Assert.AreEqual("LXI", ConvertToRoman(61));
        }
        [TestMethod]
        public void EightyTwoTest()
        {
            Assert.AreEqual("LXXXII", ConvertToRoman(82));
        }
        [TestMethod]
        public void NinetyThreeTest()
        {
            Assert.AreEqual("XCIII", ConvertToRoman(93));
        }
        string ConvertToRoman(int number)
        {
            if (number <= 9)
            {
                return roman[number];
            }
            else if (number == 10)
            {
                return tenth[1];
            }
            else if (number < 40)
            {

                int nrOfTens = number / 10;
                int nrOfRoman = number - nrOfTens * 10;
                string finalNumber = tenth[nrOfTens] + roman[nrOfRoman];
                return finalNumber;
            }
            else if (number == 40)
            {
                return forty[1];
            }
            else if (number < 49)
            {
                int intNumber = number / 10;
                int rest = number - intNumber * 10;
                string finalNum = forty[1] + roman[rest];
                return finalNum;
            }
            else if (number == 50)
            {
                return forty[2];
            }
            else if (number < 60)
            {
                int roundNumber = number / 10;
                int rests = number - roundNumber * 10;
                string finalNum = forty[2] + roman[rests];
                return finalNum;
            }
            else if (number == 60)
            {
                return forty[2] + tenth[1];
            }
            else if (number < 90)
            {
                int aNumber = (number - 50) / 10;
                int restss = (number - 50) - aNumber * 10;
                string finNumber = forty[2] + tenth[aNumber] + roman[restss];
                return finNumber;
            }
            else if (number == 90)
            {
                return forty[3];
            }
            else if (number < 100)
            {
                int bNumber = number / 10;
                int resst = number - bNumber * 10;
                string finNum = forty[3] + roman[resst];
                return finNum;
            }
            else
            {
                return forty[4];
            }
        }
    }
}







