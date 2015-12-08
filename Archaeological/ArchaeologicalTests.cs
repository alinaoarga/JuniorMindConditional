using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archaeological
{
    [TestClass]
    public class ArchaeologicalTest
    {
        [TestMethod]
        public void FirstAreaTest()
        {
            double area = CalculateArea(1, 2, 0, 1, 2, 3);
            Assert.AreEqual(0, area);
        }
        [TestMethod]
        public void SecondAreaTest()
        {
            double area = CalculateArea(0, 3, 4, 0, 0, 0);
            Assert.AreEqual(6, area);
        }
        // Am notat cu xA,yA,xB,yB,xC,yC coordonatele punctelor A, B, C, cu a,b,c, laturile triunghiului ABC si cu p semiperimetrul
        double CalculateArea(float xA, float yA, float xB, float yB, float xC, float yC)
        {
            double a = Math.Sqrt((xC - xB) * (xC - xB) + (yC - yB) * (yC - yB));
            double b = Math.Sqrt((xC - xA) * (xC - xA) + (yC - yA) * (yC - yA));
            double c = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA));
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            // Conditia de coliniaritate a punctelor
            if (xA * yB + xB * yC + yA * xC - xC * yB - yA * xB - yC * xA == 0)
            {
                return 0;
            }
            else
            {
                return area;
            }
        }
    }
}