using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabukovDV.Sprint6.V16.Lib;

namespace Tyuiu.ShabukovDV.Sprint6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string res = ds.SaveToFileTextData(3);
            string wait = "3,111";
            Assert.AreEqual(wait, res);
        }
    }
}
