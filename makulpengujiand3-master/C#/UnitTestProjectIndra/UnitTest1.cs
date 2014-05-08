using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;

namespace UnitTestProjectIndra
{
    [TestClass]
    public class UnitTest1
    {
        double a = 21;
        double b = 7;
        MainWindow mw = new MainWindow();
        
        [TestMethod]
        public void TestMethodTambah()
        {
            double actual = 28;
            double expected = mw.Tambah(a, b);
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void TestMethodKurang()
        {
            double actual = 14;
            double expected = mw.Kurang(a, b);
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void TestMethodKali()
        {
            double actual = 147;
            double expected = mw.Kali(a, b);
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void TestMethodBagi()
        {
            double actual = 3;
            double expected = mw.Bagi(a, b);
            Assert.AreEqual(actual, expected);

        }
    }
}
