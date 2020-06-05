using ClassRoom.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom.Tests.ValueObjects
{
    [TestClass]
    public class EmailTests
    {
        [TestMethod]
        [TestCategory("Email Tests")]
        public void DeveRetornarFalseSeEmailForNulo()
        {
            var email = new Email(null);
            Assert.AreEqual(false, email.Valid);
        }

        [TestMethod]
        public void DeveRetornarFalseSeEmailEstiverEmBranco()
        {
            var email = new Email("");
            Assert.AreEqual(false, email.Valid);
        }

        [TestMethod]
        public void DeveRetornarVerdadeiraSeEmailForValido()
        {
            var email = new Email("lima@gmail.com");
            Assert.IsTrue(email.Valid);
        }
    }
}
