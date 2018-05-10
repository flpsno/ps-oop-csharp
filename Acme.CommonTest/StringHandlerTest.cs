using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //-- Arrange
            var source = "SonicScrewdrive";
            var expected = "Sonic Screwdrive";

            //-- Act
            var actual = source.InsertSpaces();
            //var actual = StringHandler.InsertSpaces(source);

            //-- Asser
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            //-- Arrange
            var source = "Sonic Screwdrive";
            var expected = "Sonic Screwdrive";

            //-- Act
            var actual = source.InsertSpaces();
            //var actual = StringHandler.InsertSpaces(source);

            //-- Asser
            Assert.AreEqual(expected, actual);
        }
    }
}
