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
        decimal CalculateArrears(int days, decimal rent)
        {
            decimal RentPlusPenalty = rent + days * (2 * rent / 100);
            return RentPlusPenalty;
        }
    }
}
