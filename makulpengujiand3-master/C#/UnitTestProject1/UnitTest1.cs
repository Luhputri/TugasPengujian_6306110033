using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void Tambah()
        {
            MainWindow cal = new MainWindow();
            double bil1 = 2;
            double bil2 = 3;
            double result = 5;
            double x = cal.tambah(bil1, bil2);
            Assert.AreEqual(result, x, "salah");
        }
        [TestMethod]
        public void kurang()
        {
            MainWindow cal = new MainWindow();
            double bil1 = 5;
            double bil2 = 3;
            double result = 2;
            double x = cal.kurang(bil1, bil2);
            Assert.AreEqual(result, x, "salah");
        }

        [TestMethod]
        public void kali()
        {
            MainWindow cal = new MainWindow();
            double bil1 = 4;
            double bil2 = 3;
            double result = 12;
            double x = cal.kali(bil1, bil2);
            Assert.AreEqual(result, x, "salah");
        }

        [TestMethod]
        public void Bagi()
        {
            MainWindow cal = new MainWindow();
            double bil1 = 6;
            double bil2 = 3;
            double result = 2;
            double x = cal.bagi(bil1, bil2);
            Assert.AreEqual(result, x, "salah");
        }
    }
}
