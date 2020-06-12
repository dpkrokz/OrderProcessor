using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderProcessor.UnitTests
{
    [TestClass]
    public class ProcessorTest
    {
        [TestMethod]
        public void InitiateCheckout_BookOrder_ReturnsTrue()
        {
            // Arrange
            Processor process = new Processor();
            List<Product> products = new List<Product> {
                new Product { Name="Twilight", Type=Enum.ProductType.BookOrder}
                };

            // Act
            var expected = process.InitiateCheckout(products);

            // Assert
            Assert.IsTrue(expected);
        }
    }
} 
