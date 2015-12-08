using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void FizzTest()
        {
            Assert.AreEqual("Fizz", CalculateMultiple(9));
        }
        [TestMethod]
        public void BuzzTest()
        {
            Assert.AreEqual("Buzz", CalculateMultiple(20));
        }
        [TestMethod]
        public void FizzBuzzTest()
        {
            Assert.AreEqual("FizzBuzz", CalculateMultiple(15));
        }

        string CalculateMultiple(double number)
        {
            string str1 = "Fizz";
            string str2 = "Buzz";
            string str3 = "FizzBuzz";
            if (number % 3 == 0 & number % 5 == 0)
            {
                return str3;
            }
            else if (number % 3 == 0)
            {
                return str1;
            }
            else if (number % 5 == 0)
            {
                return str2;
            }

            else
            {
                string x = "nu se divide si cu 3 si cu 5";
                return x;
            }

        }
    }
}


