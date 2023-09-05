using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ElsufevMP.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Michael";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Hello, Michael", res);
        }
    }
}
