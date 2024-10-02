using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhudiNA.Sprint1.Task2.V19.Lib;

namespace Tyuiu.KhudiNA.Sprint1.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertInchToKm(x);
            Assert.AreEqual(res, 1.242);
        }
    }
}