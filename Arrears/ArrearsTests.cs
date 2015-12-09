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
            Assert.AreEqual(104, CalculateArrears(2, 100, 2));
        }
        [TestMethod]
        public void SecondPenaltyTest()
        {
            Assert.AreEqual(155, CalculateArrears(11, 100, 5));
        }
        [TestMethod]
        public void ThirdPenaltyTest()
        {
            Assert.AreEqual(420, CalculateArrears(32, 100, 10));
        }
        decimal CalculateArrears(int days, decimal rent, decimal percent)
        {
            decimal typeOfRent = rent + days * (percent * rent / 100);
            if (AreUpToTenDays(days))
            {
                percent = 2;
                return typeOfRent;
            }
            else if (AreUpToThirtyDays(days))
            {
                percent = 5;
                return typeOfRent;
            }
            else if (AreUpToFortyDays(days))
                percent = 10;
            return typeOfRent;
        }
        private bool AreUpToFortyDays(int days)
        {
            return days < 40;
        }

        private bool AreUpToThirtyDays(int days)
        {
            return days < 30;
        }

        private static bool AreUpToTenDays(int days)
        {
            return days < 10;
        }
    }
}
