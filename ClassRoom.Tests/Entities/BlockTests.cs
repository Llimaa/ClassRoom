using ClassRoom.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassRoom.Tests.Entities
{
    [TestClass]
    [TestCategory("Tests Blocks")]
    public class BlockTests
    {
        [TestMethod]
        public void DeveRetornarFalsoSeBlockForNulo()
        {
            var block = new Block(null);
            Assert.IsFalse(block.Valid);
        }

        [TestMethod]
        public void DeveRetornarFalsoSeBlockEstiveVazio()
        {
            var block = new Block("");
            Assert.IsFalse(block.Valid);
        }

        [TestMethod]
        public void DeveRetornarFalsoBlockForInvalido()
        {
            var block = new Block("ML");
            Assert.IsFalse(block.Valid);
        }

        [TestMethod]
        public void DeveRetornarVerdadeiroSeBlockForValido()
        {
            var block = new Block("Bloco J");
            Assert.IsTrue(block.Valid);
        }
    }
}
