using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0218
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the desired future value.
            Console.Write("Enter the desired future value: ");
            var futureValue = float.Parse(Console.ReadLine());

            // Get the annual interest rate.
            Console.Write("Enter the annual interest rate: ");
            var rate = float.Parse(Console.ReadLine());

            // Get the number of years that the money will appreciate.
            Console.Write("Enter the number of years the money will grow: ");
            var years = int.Parse((Console.ReadLine()));

            // Calculate the amount needed to deposit.
            var presentValue = futureValue / Math.Pow((1.0 + rate), years);

            // Display the amount needed to deposit
            Console.WriteLine();
            Console.WriteLine("You will need to deposit this amount: {0}", presentValue);
            Console.ReadLine();
        }
    }
}
