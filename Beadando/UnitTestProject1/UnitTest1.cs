using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Beadando;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesztGombaÁr()
        {
            AlapPizza p = new Gomba(new AlapPizza32());

            int expected = 590;
            int actual = p.ar;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TesztSonkaÁr()
        {
            AlapPizza p = new Sonka(new AlapPizza32());
            int expected = 610;
            int actual = p.ar;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TesztSonkaInfo()
        {
            AlapPizza p = new Sonka(new AlapPizza32());
            string actual = p.info;
            string elvart = "32 cm alap" + " +sonka ";
            Assert.AreEqual(elvart, actual);

        }
        [TestMethod]
        public void TesztSonkaGombaÁr()
        {
            AlapPizza p = new Sonka(new Gomba(new AlapPizza32()));
            int expected = 700;
            int actual = p.ar;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TesztBugacciÁr()
        {
            AlapPizza p = new Paradicsom(new Csirkemaj(new Erospaprika(new AlapPizza32())));
            int expected = 700;
            int actual = p.ar;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TesztBugacciInfo()
        {
            AlapPizza p = new Paradicsom(new Csirkemaj(new Erospaprika(new AlapPizza32())));
            string actual = p.info;
            string elvart = "32 cm alap" + "+ erőspaprika " + "+ csirkemáj " + "+ paradicsom ";
            Assert.AreEqual(elvart, actual);

        }
        [TestMethod]
        public void TesztSajtosTejfölösÁr()
        {
            AlapPizza p = new Sajt(new Tejfol(new AlapPizza32()));
            int expected = 640;
            int actual = p.ar;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TesztMargharitaÁr()
        {
            AlapPizza p = new Sajt(new Paradicsom(new AlapPizza32()));
            int expected = 570;
            int actual = p.ar;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TesztMargharitaInfo()
        {
            AlapPizza p = new Sajt(new Paradicsom(new AlapPizza32()));
            string actual = p.info;
            string elvart = "32 cm alap" + "+ paradicsom " + "+sajt";
            Assert.AreEqual(elvart, actual);

        }

        [TestMethod]
        public void TesztMindentbeleaÁr()
        {
            AlapPizza p = new Sajt(new Gomba(new Szalami(new Csaszarszalonna(new Olajbogyo(new Paradicsom(new Erospaprika(new Hagyma(new Fokhagyma(new AlapPizza32())))))))));
            int expected = 1170;
            int actual = p.ar;
            Assert.AreEqual(expected, actual);
        }        
    }
}
