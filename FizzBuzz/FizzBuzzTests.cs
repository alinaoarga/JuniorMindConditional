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
            Assert.AreEqual();
        }
        string CalculateMultiple(double number)
        {
            string str1 = "Fizz";
            string str2 = "Buzz";
            string str3 = "FizzBuzz";
            if(number % 3 == 0)
            {
                return str1;
            }
            else if(number % 5 == 0)
            {
                return str2;
            }
            else if(number % 3)
            {
                return str3;
            }
        }
        }
    }

