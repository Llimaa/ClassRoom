using ClassRoom.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom.Tests.Entities
{
    [TestClass]
    [TestCategory("Tests Entity Address")]
    public class AddressTests
    {
        private Address _addressValid;
        private Address _addressInvalid;

        public AddressTests()
        {
            _addressValid = new Address("Libano", "100", "77809240", "Eldorado", "Araguaina", "TO", "Brasil");
            _addressInvalid = new Address("L", "100", "778", "", "Araguaina", "     ", "");
        }
        [TestMethod]
        public void DeveRetornarVerdadeiroSeEnderecoValido()
        {
            Assert.IsTrue(_addressValid.Valid);
        }

        [TestMethod]
        public void DeveRetornarFalsoSeEnderecoInvalido()
        {
            Assert.IsFalse(_addressInvalid.Valid);
        }
    }
}
