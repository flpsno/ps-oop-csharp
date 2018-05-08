using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expect = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            //Assert.AreEqual(expect, actual);
            Assert.AreEqual(expect.CustomerId, actual.CustomerId);
            Assert.AreEqual(expect.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expect.FirstName, actual.FirstName);
            Assert.AreEqual(expect.LastName, actual.LastName);
        }
    }
}
