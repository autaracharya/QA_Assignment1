using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceG7_QA_A1
{
    public class Product
    {
        // Property for storing the unique Product ID
        public int ProdID_g7 { get; set; }

        // Property for storing the name of the product
        public string ProdName_g7 { get; set; }

        // Property for storing the price of the product
        public decimal ItemPrice_g7 { get; set; }

        // Property for storing the stock amount, only accessible within the class
        public int StockAmount_g7 { get; private set; }

        // Constructor for initializing the Product object with validation checks
        public Product(int prodID_g7, string prodName_g7, decimal itemPrice_g7, int stockAmount_g7)
        {
            try
            {
                // Validate Product ID range
                if (prodID_g7 < 10 || prodID_g7 > 100000)
                    Console.WriteLine("Product ID must be between 10 and 100000.");
                // Validate Product Price range
                else if (itemPrice_g7 < 10 || itemPrice_g7 > 10000)
                    Console.WriteLine("Price must be between $10 and $10,000.");
                // Validate Stock Amount range
                else if (stockAmount_g7 < 1 || stockAmount_g7 > 100000)
                    Console.WriteLine("Stock must be between 1 and 100,000.");
                else
                {
                    // Assign values to properties if validation passes
                    ProdID_g7 = prodID_g7;
                    ProdName_g7 = prodName_g7 ?? throw new ArgumentNullException(nameof(prodName_g7));
                    ItemPrice_g7 = itemPrice_g7;
                    StockAmount_g7 = stockAmount_g7;
                }
            }
            catch (Exception ex)
            {
                // Catch and display any unexpected errors during initialization
                Console.WriteLine($"Error initializing Product: {ex.Message}");
            }
        }

        // Method to increase the stock amount of the product
        public void IncreaseStock_g7(int amount_g7)
        {
            try
            {
                // Ensure the amount to increase is greater than 0
                if (amount_g7 <= 0)
                    Console.WriteLine("Amount must be greater than 0.");
                else
                    StockAmount_g7 += amount_g7; // Add the specified amount to the stock
            }
            catch (Exception ex)
            {
                // Catch and display any unexpected errors during stock increase
                Console.WriteLine($"Error increasing stock: {ex.Message}");
            }
        }

        // Method to decrease the stock amount of the product
        public void DecreaseStock_g7(int amount_g7)
        {
            try
            {
                // Ensure the amount to decrease is greater than 0
                if (amount_g7 <= 0)
                    Console.WriteLine("Amount must be greater than 0.");
                // Check if the amount to decrease exceeds the current stock
                else if (amount_g7 > StockAmount_g7)
                    Console.WriteLine("Cannot decrease stock below zero.");
                else
                    StockAmount_g7 -= amount_g7; // Subtract the specified amount from the stock
            }
            catch (Exception ex)
            {
                // Catch and display any unexpected errors during stock decrease
                Console.WriteLine($"Error decreasing stock: {ex.Message}");
            }
        }
    }
}
