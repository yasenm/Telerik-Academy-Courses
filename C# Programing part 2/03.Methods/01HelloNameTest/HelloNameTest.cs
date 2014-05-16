using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01HelloName;

namespace _01HelloNameTest
{
    [TestClass]
    public class HelloNameTest
    {
        [TestMethod]
        public void TestNamesPerson()
        {
            string result = HelloName.NameHello("Pesho");
            Assert.AreEqual("Hello Pesho",result);
        }
        [TestMethod]
        public void TestNamesTowns()
        {
            string result = HelloName.NameHello("Sofia");
            Assert.AreEqual("Hello Sofia", result);
        }
        [TestMethod]
        public void TestRandomWord()
        {
            string result = HelloName.NameHello("iyfiudhfvkjdhfvgkjdf");
            Assert.AreEqual("Hello iyfiudhfvkjdhfvgkjdf", result);
        }
        [TestMethod]
        public void TestNumber()
        {
            string result = HelloName.NameHello("897896789");
            Assert.AreEqual("Hello 897896789", result);
        }
    }
}
