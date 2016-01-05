using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumbers
{
    [TestClass]
    public class RomanNumbersTests
    {
        string[] roman = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        string[] tenth = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] hundred = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
        string[] thousand = { "", "M", "MM", "MMM" };

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
        [TestMethod]
        public void OneHundredOneTest()
        {
            Assert.AreEqual("CI", ConvertToRoman(101));
        }
        [TestMethod]
        public void ThreeHundredOneTest()
        {
            Assert.AreEqual("CCCI", ConvertToRoman(301));
        }
        [TestMethod]
        public void EightHundredTwentyThreeTest()
        {
            Assert.AreEqual("DCCCXXIII", ConvertToRoman(823));
        }
        [TestMethod]
        public void OneThousandTest()
        {
            Assert.AreEqual("M", ConvertToRoman(1000));
        }
        [TestMethod]
        public void ThreeThousandEightHundredTwentyFiveTest()
        {
            Assert.AreEqual("MMMDCCCXXV", ConvertToRoman(3825));
        }
        [TestMethod]
        public void ThreeThousandNineHundredNinetyNineTest()
        {
            Assert.AreEqual("MMMCMXCIX", ConvertToRoman(3999));
        }
        string ConvertToRoman(int number)
        {
            int thousands = number / 1000;
            int hundreds = (number - thousands * 1000) / 100;
            int tens = ((number - thousands * 1000) - (hundreds * 100)) / 10;
            int units = ((number - thousands * 1000) - (hundreds * 100)) % 10;
            return thousand[thousands] + hundred[hundreds] + tenth[tens] + roman[units];
        }
    }
}







