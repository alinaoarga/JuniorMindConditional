using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arrears
{
    [TestClass]
    public class ArrearsTests
    {
        [TestMethod]
        public void FirstPenaltyTest()
        {
            Assert.AreEqual(104, CalculateArrears(2, 100));
        }
        [TestMethod]
        public void SecondPenaltyTest()
        {
            Assert.AreEqual(155, CalculateArrears(11, 100));
        }
        decimal CalculateArrears(int days, decimal rent)
        {
           decimal firstTypeOfRent = rent + days * (2 * rent / 100);
            decimal secondTypeOfRent = rent + days * (5 * rent / 100);
            return days < 10 ? firstTypeOfRent : secondTypeOfRent;
        }
    }
}
