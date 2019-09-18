using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AchaoCalculator;


namespace AchaoCalculator测试单元
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "2*3+5-10";
            Assert.AreEqual(Program.MainCal(s),1);

        }
    }
}
