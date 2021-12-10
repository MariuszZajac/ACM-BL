﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //-- Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
           
            //-- Act
            var actual =source.InsertSpaces();
            
            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}