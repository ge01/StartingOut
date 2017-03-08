using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0220
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program demonstrates how a floating-point
            // number is displayed with no formatting.
            var amountDue = 5000.0;
            var monthlyPayment = amountDue / 12.0;
            Console.WriteLine("The monthly payment is " + monthlyPayment.ToString("F2"));
            Console.ReadLine();
        }
    }
}
