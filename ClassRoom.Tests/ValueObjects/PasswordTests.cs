using ClassRoom.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom.Tests.ValueObjects
{
    [TestClass]
    [TestCategory("Tests Password")]
    public class PasswordTests
    {
        [TestMethod]
        public void DeveRetornarFalsoSeSenhaForNula()
        {
            var passwoord = new Password(null);
            Assert.IsFalse(passwoord.Valid);
        }

        [TestMethod]
        public void DeveRetornarFalsoSeSenhaForMenorQueSeis()
        {
            var password = new Password("12345");
            Assert.IsFalse(password.Valid);
        }

        [TestMethod]
        public void DeveRetornarFalsoQuandoSenhaMaiorQueDes()
        {
            var password = new Password("12345679999");
            Assert.AreEqual(false, password.Valid);
        }

        [TestMethod]
        public void DeveRetornarVerdadeiraQuandoSenhaValida()
        {
            var password = new Password("12398453");
            Assert.IsTrue(password.Valid);
        }
    }
}
