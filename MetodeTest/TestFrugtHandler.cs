using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ÆblerPærerGenerics;

namespace MetodeTest
{
    [TestClass]
    public class TestFrugtHandler
    {
        [TestMethod]
        public void TestCalculateSumÆblerFlere()
        {
            var æbleBeholdning = new List<Æbler>();
            æbleBeholdning.Add(new Æbler() { Navn = "Ingrid Marie", Lager = 50, Pris = 20.0M });
            æbleBeholdning.Add(new Æbler() { Navn = "Cox Orange", Lager = 25, Pris = 10.0M });

            Assert.AreEqual(1250,FrugtHandler.BeregnGenericSumDecimal(æbleBeholdning));
        }

        [TestMethod]
        public void TestCalculateSumÆblerEnkelt()
        {
            var æbleBeholdning = new List<Æbler>();
            æbleBeholdning.Add(new Æbler() { Navn = "Ingrid Marie", Lager = 50, Pris = 20.0M });
            Assert.AreEqual(1000, FrugtHandler.BeregnGenericSumDecimal(æbleBeholdning));
        }


        [TestMethod]
        public void TestCalculateSumÆblerIngen()
        {
            var æbleBeholdning = new List<Æbler>();
            Assert.AreEqual(0, FrugtHandler.BeregnGenericSumDecimal(æbleBeholdning));
        }

        [TestMethod]
        public void TestCalculateSumPærerFlere()
        {
            var pærerBeholdning = new List<Pærer>();
            pærerBeholdning.Add(new Pærer() { Navn = "Conference", Lager = 10M, Pris = 5M });
            pærerBeholdning.Add(new Pærer() { Navn = "Concorde", Lager = 15, Pris = 10M });

            Assert.AreEqual(200, FrugtHandler.BeregnGenericSumDecimal(pærerBeholdning));
        }

        [TestMethod]
        public void TestCalculateSumPærerEnkelt()
        {
            var pærerBeholdning = new List<Pærer>();
            pærerBeholdning.Add(new Pærer() { Navn = "Conference", Lager = 10M, Pris = 5M });

            Assert.AreEqual(50, FrugtHandler.BeregnGenericSumDecimal(pærerBeholdning));
        }


        [TestMethod]
        public void TestCalculateSumPærerIngen()
        {
            var pærerBeholdning = new List<Pærer>();

            Assert.AreEqual(0, FrugtHandler.BeregnGenericSumDecimal(pærerBeholdning));
        }

    }
}
