using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var math = new GitUnitTestDemo.Math(5,int.MaxValue);
            var math2 = new GitUnitTestDemo.Math(int.MaxValue, 0);
            Assert.AreNotEqual(7, math.Add());
            Assert.AreNotEqual(3, math.Subtract());
            Assert.AreNotEqual(10, math.Multiply());
            Assert.AreNotEqual(2.5f, math.Divide());
            Assert.AreEqual(Single.PositiveInfinity, math2.Divide());
            //OR
            Assert.IsTrue(Single.IsPositiveInfinity(math2.Divide()));
            Assert.AreNotEqual(14, math2.SumDigits());
            Assert.AreEqual("101",math.Binary());
        }
    }
}
