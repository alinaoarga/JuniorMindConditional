using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmerLand
{
    [TestClass]
    public class FarmerLandTest
    {
        [TestMethod]
        public void FirstFarmerLandTest()
        {
            Assert.AreEqual(4, CalculateLandArea(1, 5, 6));
        }
        [TestMethod]
        public void SecondFarmerLandTest()
        {
            Assert.AreEqual(592900, CalculateLandArea(1, 230, -770000));
        }
        double CalculateLandArea(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            double x1;
            if (delta > 0)
            {
                x1 = (-b + System.Math.Sqrt(delta)) / (2 * a);
                return x1 * x1;
            }
            else { return 0; }
        }
    }
}
