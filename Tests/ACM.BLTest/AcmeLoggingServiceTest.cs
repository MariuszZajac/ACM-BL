using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //-- Arrange
            var changeItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "fbagins@hobbit.me ",
                FirstName = "Frodo",
                LastName = "Bagins",
                AddressList = null
            };
            changeItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "22 rake",
                CurrentPrice = 6M,
            };
            changeItems.Add(product);
            //-- Act
            LoggingService.WriteToFile(changeItems);

            //-- Assert
        }
    }
}