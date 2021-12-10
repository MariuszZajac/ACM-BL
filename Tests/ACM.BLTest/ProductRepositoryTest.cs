﻿using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
               ProductName = "Sunflowers",
               ProductDescription ="4Yellow sunflowers",
               CurrentPrice= 15.96M,
            };
            //-- Act
            var actual = productRepository.Retrieve(2);

            //-- Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }
    }
}
