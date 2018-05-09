using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expeted = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot row",
                        City = "Hobbiton",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Green Dragon",
                        City = "Bywater",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "146"
                    }
                }
            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expeted.CustomerId, actual.CustomerId);
            Assert.AreEqual(expeted.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expeted.FirstName, actual.FirstName);
            Assert.AreEqual(expeted.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expeted.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expeted.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expeted.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expeted.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expeted.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expeted.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }

        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var expected = new OrderDisplay()
            {
                FirstName = "Bilbo",
                LastName = "Baggins",
                OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(1, 0, 0)),
                ShippingAddress = new Address()
                {
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                },

                OrderDisplayItemList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        ProductName = "Sunflowers",
                        PuchasePrice = 15.96M,
                        OrderQuantity = 2
                    },
                    new OrderDisplayItem()
                    {
                        ProductName = "Rake",
                        PuchasePrice = 6M,
                        OrderQuantity = 1
                    }
                }
            };

            //-- Act
            var actual = orderRepository.RetrieveOrderDisplay(10);

            //-- Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

            Assert.AreEqual(expected.ShippingAddress.AddressType, actual.ShippingAddress.AddressType);
            Assert.AreEqual(expected.ShippingAddress.StreetLine1, actual.ShippingAddress.StreetLine1);
            Assert.AreEqual(expected.ShippingAddress.City, actual.ShippingAddress.City);
            Assert.AreEqual(expected.ShippingAddress.State, actual.ShippingAddress.State);
            Assert.AreEqual(expected.ShippingAddress.Country, actual.ShippingAddress.Country);
            Assert.AreEqual(expected.ShippingAddress.PostalCode, actual.ShippingAddress.PostalCode);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.OrderDisplayItemList[i].OrderQuantity, actual.OrderDisplayItemList[i].OrderQuantity);
                Assert.AreEqual(expected.OrderDisplayItemList[i].ProductName, actual.OrderDisplayItemList[i].ProductName);
                Assert.AreEqual(expected.OrderDisplayItemList[i].PuchasePrice, actual.OrderDisplayItemList[i].PuchasePrice);
            }
        }
    }
}
