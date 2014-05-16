using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04TimesNumberApearInArray;

namespace _04TimesNumberApearInArrayTest
{
    [TestClass]
    public class TimesNumberAppearInArrayTest
    {
        [TestMethod]
        public void TestWithSameIntArray()
        {
            int[] array = {1,1,1,1 };
            int testResult = TimesNumberAppearInArray.AppearancesOfNumberInArray(1,array);
            Assert.AreEqual(4,testResult);
        }
        [TestMethod]
        public void TestWithRandomIntArray()
        {
            int[] array = { 1, 2, 3, 12314, 456,24, 23, 3, 5435, 5435, 123125, 767512, 12,3123,1231,5435 };
            int testResult = TimesNumberAppearInArray.AppearancesOfNumberInArray(5435, array);
            Assert.AreEqual(3, testResult);
        }
        [TestMethod]
        public void TestWithoutNumberIntArray()
        {
            int[] array = { 1, 2, 3, 12314, 456, 24, 23, 3, 5435, 5435, 123125, 767512, 12, 3123, 1231, 5435 };
            int testResult = TimesNumberAppearInArray.AppearancesOfNumberInArray(-6000, array);
            Assert.AreEqual(0, testResult);
        }
    }
}
