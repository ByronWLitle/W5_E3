using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5_E3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            int selectChoice = 0;
            string userInput = "";
            Console.WriteLine("Welcome to the store!");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Press 1 to add more product(s), press 2 to remove a product, press 3 to calculate price. To exit the program, press 4.");
                selectChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (selectChoice)
                {
                    case 1:
                        Console.WriteLine("What would you like to get?");
                        string userProductName = Console.ReadLine();
                        Console.WriteLine("What is the Product ID?");
                        string userProductID = Console.ReadLine();
                        Console.WriteLine("What is the price?");
                        double userPrice = Convert.ToDouble(Console.ReadLine());
                        cart.AddProduct(userProductID, userProductName, userPrice);
                        break;
                    case 2:
                        Console.WriteLine("What would you like to remove?");
                        userInput = Console.ReadLine();
                        cart.RemoveProduct(userInput);
                        break;
                    case 3:
                        Console.WriteLine($"Your total comes out to: {cart.CalculateTotalPrice()}");
                        break;
                    case 4:
                        break;
                }
            } while (selectChoice != 4);
        }
        class Product
        {
            public string ProductID = "";
            public string ProductName = "";
            public double Price = 0;
        }
        class ShoppingCart
        {
            List<Product> Items = new List<Product>();
                
            public void AddProduct(string aProductID, string aProductName, double aPrice)
            {
                new Product() 
                { 
                    ProductID = aProductID, 
                    ProductName = aProductName, 
                    Price = aPrice 
                };
            }
            public void RemoveProduct(string productID) 
            {
                foreach(item i in Items)
                {

                }
            }
            public double CalculateTotalPrice()
            {
                double totalPrice = 0;
                for(int i = 0; 
                return totalPrice;
            }
        }
    }
}
