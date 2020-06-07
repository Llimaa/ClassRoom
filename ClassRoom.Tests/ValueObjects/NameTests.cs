using ClassRoom.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassRoom.Tests.ValueObjects
{
    [TestClass]
    [TestCategory("Name Tests")]
    public class NameTests
    {
        [TestMethod]
        public void DeveRetornarFalsoSeNomeForVazio()
        {
            var name = new Name("", "");
            Assert.IsFalse(name.Valid);
        }

        [TestMethod]
        public void DeveRetornarFalsoSeNomeMenorQueTres()
        {
            var name = new Name("ML", "M");
            Assert.AreEqual(true, name.Invalid);
        }

        [TestMethod]
        public void DeveRetornarFalsoSeNomeMaiorQueVinte()
        {
            var name = new Name("mmmdddmdmdmdjdhejeie", "MARCOSLIMAMARCOSARww22");
            Assert.IsFalse(name.Valid);
        }

        [TestMethod]
        public void DeveRetornarVerdadeiraSeNomeForValido()
        {
            var name = new Name("Marcos", "Lima");
            Assert.IsTrue(name.Valid);
        }
    }
}
