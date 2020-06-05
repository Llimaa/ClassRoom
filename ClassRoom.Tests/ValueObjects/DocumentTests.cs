using ClassRoom.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassRoom.Tests.ValueObjects
{
    [TestClass]
    [TestCategory("Document Tests")]
    public class DocumentTests
    {
        [TestMethod]
        public void DeveRetornarFalsoQuandoDocumentoForFalso()
        {
            var document = new Document("123-456-789-11");
            Assert.AreNotEqual(true, document.Valid);
        }

        [TestMethod]
        public void DeveRetornarTrueQuandoDocumentoFOrVerdadeiro()
        {
            var document = new Document("585.791.050-13");
            Assert.AreEqual(true, document.Valid);
        }

        [TestMethod]
        public void DeveRetornarFalsoQuandoDocumentoForNull()
        {
            var document = new Document(null);
            Assert.AreEqual(false, document.Valid);
        }

        [TestMethod]
        public void deveRetornarFalsoQuandoDocumentForMaiorQueOnze()
        {
            var document = new Document("123456789012");
            Assert.IsFalse(document.Valid);
        }

        [TestMethod]
        public void DeveRetornarFalsoQuandoCNPJForFalso()
        {
            var documment = new Document("01.235.258/1015-12");
            Assert.IsFalse(documment.Valid);
        }

        [TestMethod]
        public void DeveRetornarVerdadeiroQuandoCNPJForVerdadeiro()
        {
            var document = new Document("41.605.383/0001-09");
            Assert.IsTrue(document.Valid);
        }
    }
}
