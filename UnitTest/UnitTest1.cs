using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameNumber;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUnit()
        {
            var number = new NameNambers(7);
            var result = number.Unit;
            Assert.AreEqual("seven", result);
        }

        [TestMethod]
        public void TestTeen()
        {
            var number = new NameNambers(12);
            var result = number.Teen;
            Assert.AreEqual("twelve", result);
        }

        [TestMethod]
        public void TestTen()
        {
            var number = new NameNambers(86);
            var result = number.Ten;
            Assert.AreEqual("eighty six", result);
        }

        [TestMethod]
        public void TestHundread()
        {
            var number = new NameNambers(500);
            var result = number.Hundread;
            Assert.AreEqual("five hundread", result);
        }

        [TestMethod]
        public void TestThousand()
        {
            var number = new NameNambers(7125);
            var result = number.Thousand;
            Assert.AreEqual("seven thousand one hundread and twenty five", result);
        }
    }
}
