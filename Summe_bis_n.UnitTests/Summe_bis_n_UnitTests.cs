using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Summe_bis_n;

namespace Summe_bis_n.UnitTests
{
    [TestClass]
    public class Summe_bis_n_UnitTests
    {
        [TestMethod]
        public void Summe_bis_n_Test1()
        {
            Summe_bis_n prg = new Summe_bis_n();

            var summe = prg.Summe_bis_n_Methode(123);

            Assert.AreEqual(7503, summe);
        }
    }
}
