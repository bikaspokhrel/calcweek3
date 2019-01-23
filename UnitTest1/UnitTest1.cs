using System;
using calcweek3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        Form1 f = new Form1();
        [TestMethod]
        public void Multiply()
        {
            Single answer = f.Multiply(2, 2);
            Assert.AreEqual(4, answer);
        }
        public void Multiply()
        {
            Single answer = f.Multiply(2, 2);
            Assert.AreEqual(4, answer);
        }
    }
}
