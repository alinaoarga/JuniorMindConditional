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
       
        string CalculateMultiple(double number)
        {
            string str1 = "Fizz";
            string str2 = "Buzz";
            string str3 = "FizzBuzz";
            if (number % 3 == 0)
            {
                return str1;
            }
            else if (number % 5 == 0)
            {
                return str2;
            }
            else return ((number % 3 == 0) && (number % 5 == 0)) ? str3 : str3;
        }
        }
    }

