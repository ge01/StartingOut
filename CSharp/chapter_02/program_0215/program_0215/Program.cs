using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0215
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program gets an item's original price and
            // calculates its sale price, with a 20% discount

            // Get the item's original price.
            Console.Write("Enter the item's original price: ");
            float originalPrice = Convert.ToSingle(Console.ReadLine());

            // Calculate the amount of the discount.
            double discount = originalPrice * 0.2;

            // Calculate the sale price.
            double salePrice = originalPrice - discount;

            // Display the sale price.
            Console.WriteLine("The sale price is {0}", salePrice.ToString("C2"));

            Console.ReadLine();

        }
    }
}
