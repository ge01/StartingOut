using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0307
{
    class Program
    {
        // This program converts cups to fluid ounces.
        static void Main(string[] args)
        {
            // Display the intro screen.
            intro();
            
            // Get the number of cups.
            Console.WriteLine("Enter the number of cups: ");
            var cups_needed = int.Parse(Console.ReadLine());

            // Convert the cups to ounces.
            cups_to_ounces(cups_needed);
            Console.ReadLine();
        }

        // The intro function displays an introductory screen.
        static void intro()
        {
            Console.WriteLine("This program converts measurements");
            Console.WriteLine("in cups to fluid ounces. For your");
            Console.WriteLine("reference the formula is: ");
            Console.WriteLine(" 1 cup = 8 fluid ounces");
            Console.WriteLine("");
        }

        // The cups_to_ounces function accepts a number of 
        // cups and displays the equivalent number of ounces.
        static void cups_to_ounces(int cups)
        {
            var ounces = cups * 8;
            Console.WriteLine("That converts to " + ounces + " ounces.");
            Console.WriteLine("That converts to {0} ounces.", ounces);
        }
    }
}
