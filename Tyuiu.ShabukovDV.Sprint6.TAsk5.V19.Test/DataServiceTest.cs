using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabukovDV.Sprint6.TAsk5.V19.Lib;
namespace Tyuiu.ShabukovDV.Sprint6.TAsk5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\InPutFileTask5V19.txt";

            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { -17, 0, 12, 5, 35, -9, 0, -7 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
