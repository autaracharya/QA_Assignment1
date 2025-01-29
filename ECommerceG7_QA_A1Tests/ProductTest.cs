using ECommerceG7_QA_A1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceG7_QA_A1Tests
{
    [TestFixture]
    public class ProductTest
    {
        // Tests by Autar Acharya
        /*
        Test Purpose: Validate ProdID and ItemPrice attributes.
        These tests ensure that the ProdID and ItemPrice are correctly assigned within valid ranges.
        */
        [Test]
        public void Test_ProdID_Min()
        {
            // Arrange: Initialize minimum valid Product ID, sample product name, price, and stock amount
            int prodID_g7 = 10;
            string prodName_g7 = "Widget";
            decimal itemPrice_g7 = 100.00m;
            int stockAmount_g7 = 50;

            // Act: Create a Product instance with the given values
            var product_g7 = new Product(prodID_g7, prodName_g7, itemPrice_g7, stockAmount_g7);

            // Assert: Verify that the Product ID is assigned correctly
            Assert.That(product_g7.ProdID_g7, Is.EqualTo(10));
        }

        [Test]
        public void Test_ProdID_Max()
        {
            // Arrange: Initialize maximum valid Product ID, sample product name, price, and stock amount
            int prodID_g7 = 100000;
            string prodName_g7 = "Gadget";
            decimal itemPrice_g7 = 100.00m;
            int stockAmount_g7 = 50;

            // Act: Create a Product instance with the given values
            var product_g7 = new Product(prodID_g7, prodName_g7, itemPrice_g7, stockAmount_g7);

            // Assert: Verify that the Product ID is assigned correctly
            Assert.That(product_g7.ProdID_g7, Is.EqualTo(100000));
        }

        [Test]
        public void Test_ProdID_Typical()
        {
            // Arrange: Initialize typical Product ID, sample product name, price, and stock amount
            int prodID_g7 = 50000;
            string prodName_g7 = "Tool";
            decimal itemPrice_g7 = 100.00m;
            int stockAmount_g7 = 50;

            // Act: Create a Product instance with the given values
            var product_g7 = new Product(prodID_g7, prodName_g7, itemPrice_g7, stockAmount_g7);

            // Assert: Verify that the Product ID is assigned correctly
            Assert.That(product_g7.ProdID_g7, Is.EqualTo(50000));
        }

        [Test]
        public void Test_ItemPrice_Min()
        {
            // Arrange: Initialize minimum valid Item Price and other sample attributes
            int prodID_g7 = 100;
            string prodName_g7 = "Widget";
            decimal itemPrice_g7 = 10.00m;
            int stockAmount_g7 = 50;

            // Act: Create a Product instance with the given values
            var product_g7 = new Product(prodID_g7, prodName_g7, itemPrice_g7, stockAmount_g7);

            // Assert: Verify that the Item Price is assigned correctly
            Assert.That(product_g7.ItemPrice_g7, Is.EqualTo(10.00m));
        }

        [Test]
        public void Test_ItemPrice_Max()
        {
            // Arrange: Initialize maximum valid Item Price and other sample attributes
            int prodID_g7 = 100;
            string prodName_g7 = "Gadget";
            decimal itemPrice_g7 = 10000.00m;
            int stockAmount_g7 = 50;

            // Act: Create a Product instance with the given values
            var product_g7 = new Product(prodID_g7, prodName_g7, itemPrice_g7, stockAmount_g7);

            // Assert: Verify that the Item Price is assigned correctly
            Assert.That(product_g7.ItemPrice_g7, Is.EqualTo(10000.00m));
        }

        [Test]
        public void Test_ItemPrice_Typical()
        {
            // Arrange: Initialize typical Item Price and other sample attributes
            int prodID_g7 = 100;
            string prodName_g7 = "Tool";
            decimal itemPrice_g7 = 500.50m;
            int stockAmount_g7 = 50;

            // Act: Create a Product instance with the given values
            var product_g7 = new Product(prodID_g7, prodName_g7, itemPrice_g7, stockAmount_g7);

            // Assert: Verify that the Item Price is assigned correctly
            Assert.That(product_g7.ItemPrice_g7, Is.EqualTo(500.50m));
        }

        // Tests by Aadityal Aryal
        /*
        Test Purpose: Validate ProdName and StockAmount attributes.
        These tests ensure that ProdName and StockAmount can handle various valid inputs.
        */
        [Test]
        public void Test_ProdName_Valid1()
        {
            // Arrange: Initialize a sample product name and other attributes
            int prodID_g7 = 100;
            string prodName_g7 = "Widget";
            decimal itemPrice_g7 = 100.00m;
            int stockAmount_g7 = 50;

            // Act: Create a Product instance with the given values
            var product_g7 = new Product(prodID_g7, prodName_g7, itemPrice_g7, stockAmount_g7);

            // Assert: Verify that the Product Name is assigned correctly
            Assert.That(product_g7.ProdName_g7, Is.EqualTo("Widget"));
        }

        [Test]
        public void Test_ProdName_Valid2()
        {
            // Arrange: Initialize a sample product name and other attributes
            int prodID_g7 = 100;
            string prodName_g7 = "Gadget";
            decimal itemPrice_g7 = 100.00m;
            int stockAmount_g7 = 50;

            // Act: Create a Product instance with the given values
            var product_g7 = new Product(prodID_g7, prodName_g7, itemPrice_g7, stockAmount_g7);

            // Assert: Verify that the Product Name is assigned correctly
            Assert.That(product_g7.ProdName_g7, Is.EqualTo("Gadget"));
        }

        [Test]
        public void Test_ProdName_WithSpaces()
        {
            // Arrange: Initialize a product name with spaces and other attributes
            int prodID_g7 = 100;
            string prodName_g7 = "Premium Tool";
            decimal itemPrice_g7 = 100.00m;
            int stockAmount_g7 = 50;

            // Act: Create a Product instance with the given values
            var product_g7 = new Product(prodID_g7, prodName_g7, itemPrice_g7, stockAmount_g7);

            // Assert: Verify that the Product Name with spaces is assigned correctly
            Assert.That(product_g7.ProdName_g7, Is.EqualTo("Premium Tool"));
        }

        [Test]
        public void Test_Stock_Min()
        {
            // Arrange: Initialize minimum valid stock amount and other attributes
            int prodID_g7 = 100;
            string prodName_g7 = "Widget";
            decimal itemPrice_g7 = 100.00m;
            int stockAmount_g7 = 1;

            // Act: Create a Product instance with the given values
            var product_g7 = new Product(prodID_g7, prodName_g7, itemPrice_g7, stockAmount_g7);

            // Assert: Verify that the Stock Amount is assigned correctly
            Assert.That(product_g7.StockAmount_g7, Is.EqualTo(1));
        }

        [Test]
        public void Test_Stock_Max()
        {
            // Arrange: Initialize maximum valid stock amount and other attributes
            int prodID_g7 = 100;
            string prodName_g7 = "Tool";
            decimal itemPrice_g7 = 100.00m;
            int stockAmount_g7 = 100000;

            // Act: Create a Product instance with the given values
            var product_g7 = new Product(prodID_g7, prodName_g7, itemPrice_g7, stockAmount_g7);

            // Assert: Verify that the Stock Amount is assigned correctly
            Assert.That(product_g7.StockAmount_g7, Is.EqualTo(100000));
        }

        [Test]
        public void Test_Stock_Typical()
        {
            // Arrange: Initialize typical stock amount and other attributes
            int prodID_g7 = 100;
            string prodName_g7 = "Tool";
            decimal itemPrice_g7 = 100.00m;
            int stockAmount_g7 = 50000;

            // Act: Create a Product instance with the given values
            var product_g7 = new Product(prodID_g7, prodName_g7, itemPrice_g7, stockAmount_g7);

            // Assert: Verify that the Stock Amount is assigned correctly
            Assert.That(product_g7.StockAmount_g7, Is.EqualTo(50000));
        }

        // Tests by Mahakdeep Kaur
        /*
        Test Purpose: Validate stock modification methods (increase and decrease).
        These tests ensure that stock-related operations work as expected.
        */
        [Test]
        public void Test_IncreaseStock_Small()
        {
            // Arrange: Create a product with initial stock and define a small increase amount
            var product_g7 = new Product(100, "Widget", 100.00m, 50);
            int increaseAmount_g7 = 10;

            // Act: Increase the stock by the specified amount
            product_g7.IncreaseStock_g7(increaseAmount_g7);

            // Assert: Verify that the stock has increased correctly
            Assert.That(product_g7.StockAmount_g7, Is.EqualTo(60));
        }

        [Test]
        public void Test_IncreaseStock_Large()
        {
            // Arrange: Create a product with initial stock and define a large increase amount
            var product_g7 = new Product(100, "Gadget", 100.00m, 50);
            int increaseAmount_g7 = 1000;

            // Act: Increase the stock by the specified amount
            product_g7.IncreaseStock_g7(increaseAmount_g7);

            // Assert: Verify that the stock has increased correctly
            Assert.That(product_g7.StockAmount_g7, Is.EqualTo(1050));
        }

        [Test]
        public void Test_IncreaseStock_Boundary()
        {
            // Arrange: Create a product close to the maximum stock limit and define a boundary increase
            var product_g7 = new Product(100, "Tool", 100.00m, 99950);
            int increaseAmount_g7 = 50;

            // Act: Increase the stock to reach the boundary limit
            product_g7.IncreaseStock_g7(increaseAmount_g7);

            // Assert: Verify that the stock has reached the maximum limit
            Assert.That(product_g7.StockAmount_g7, Is.EqualTo(100000));
        }

        [Test]
        public void Test_DecreaseStock_Small()
        {
            // Arrange: Create a product with initial stock and define a small decrease amount
            var product_g7 = new Product(100, "Widget", 100.00m, 50);
            int decreaseAmount_g7 = 10;

            // Act: Decrease the stock by the specified amount
            product_g7.DecreaseStock_g7(decreaseAmount_g7);

            // Assert: Verify that the stock has decreased correctly
            Assert.That(product_g7.StockAmount_g7, Is.EqualTo(40));
        }

        [Test]
        public void Test_DecreaseStock_ToZero()
        {
            // Arrange: Create a product with initial stock equal to the decrease amount
            var product_g7 = new Product(100, "Gadget", 100.00m, 10);
            int decreaseAmount_g7 = 10;

            // Act: Decrease the stock to zero
            product_g7.DecreaseStock_g7(decreaseAmount_g7);

            // Assert: Verify that the stock has been reduced to zero
            Assert.That(product_g7.StockAmount_g7, Is.EqualTo(0));
        }

        [Test]
        public void Test_DecreaseStock_Boundary()
        {
            // Arrange: Create a product with stock slightly above the minimum and define a boundary decrease
            var product_g7 = new Product(100, "Tool", 100.00m, 100);
            int decreaseAmount_g7 = 99;

            // Act: Decrease the stock to just above zero
            product_g7.DecreaseStock_g7(decreaseAmount_g7);

            // Assert: Verify that the stock is reduced correctly to the boundary value
            Assert.That(product_g7.StockAmount_g7, Is.EqualTo(1));
        }


    }
}


