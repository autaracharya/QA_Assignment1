using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceG7_QA_A1
{
    public class Product
    {
        public int ProdID_g7 { get; set; }
        public string ProdName_g7 { get; set; }
        public decimal ItemPrice_g7 { get; set; }
        public int StockAmount_g7 { get; private set; }

        public Product(int prodID_g7, string prodName_g7, decimal itemPrice_g7, int stockAmount_g7)
        {
            try
            {
                if (prodID_g7 < 10 || prodID_g7 > 100000)
                    Console.WriteLine("Product ID must be between 10 and 100000.");
                else if (itemPrice_g7 < 10 || itemPrice_g7 > 10000)
                    Console.WriteLine("Price must be between $10 and $10,000.");
                else if (stockAmount_g7 < 1 || stockAmount_g7 > 100000)
                    Console.WriteLine("Stock must be between 1 and 100,000.");
                else
                {
                    ProdID_g7 = prodID_g7;
                    ProdName_g7 = prodName_g7 ?? throw new ArgumentNullException(nameof(prodName_g7));
                    ItemPrice_g7 = itemPrice_g7;
                    StockAmount_g7 = stockAmount_g7;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error initializing Product: {ex.Message}");
            }
        }

        public void IncreaseStock_g7(int amount_g7)
        {
            try
            {
                if (amount_g7 <= 0)
                    Console.WriteLine("Amount must be greater than 0.");
                else
                    StockAmount_g7 += amount_g7;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error increasing stock: {ex.Message}");
            }
        }

        public void DecreaseStock_g7(int amount_g7)
        {
            try
            {
                if (amount_g7 <= 0)
                    Console.WriteLine("Amount must be greater than 0.");
                else if (amount_g7 > StockAmount_g7)
                    Console.WriteLine("Cannot decrease stock below zero.");
                else
                    StockAmount_g7 -= amount_g7;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error decreasing stock: {ex.Message}");
            }
        }
    }
}
