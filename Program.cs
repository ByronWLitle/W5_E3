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
            //Code that outputs all products in list collection?
            do
            {
                Console.WriteLine("Press 1 to add more product(s), press 2 to remove a product, press 3 to calculate price. To exit the program, press 4.");
                selectChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (selectChoice)
                {
                    case 1:
                        Console.WriteLine("What would you like to get?");
                        userInput = Console.ReadLine();
                        cart.AddProduct(userInput);
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
            List<Product> Items = new List<Product>()
            {
                new Product(){ProductID = "A1", ProductName="Apple", Price=1.50},
                new Product(){ProductID = "A2", ProductName="Orange", Price=2.00},
                new Product(){ProductID = "B7", ProductName="Vacuum", Price=69.99},
                new Product(){ProductID = "C5", ProductName="Chips", Price=3.00},
                new Product(){ProductID = "D4", ProductName="Garden Hose", Price=19.99},
            };
                
            public void AddProduct(string product)
            {
                //Compare userInput to ProductName; add to cart after comparison
                Items.Add(product);
            }
            public void RemoveProduct(string productID) 
            {
                //Display what is in cart + productID 
                Items.Remove(productID);
            }
            public double CalculateTotalPrice()
            {
                double totalPrice = 0;
                //Grab price from list; add them; and times by 8.25%(1.0825) to include taxes
                return totalPrice;
            }
        }
    }
}
