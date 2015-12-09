using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arrears
{
    [TestClass]
    public class ArrearsTests
    {
        decimal[] percent = { 2, 5, 10 };

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
        [TestMethod]
        public void ThirdPenaltyTest()
        {
            Assert.AreEqual(420, CalculateArrears(32, 100));
        }
        decimal CalculateArrears(int days, decimal rent)
        {
            var addedPercentage = days <= 10 ? percent[0] * days : days <= 30 ? percent[1] * days : percent[2] * days;
            return rent + rent * addedPercentage / 100;
        }
    }
}