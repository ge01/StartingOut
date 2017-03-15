using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0221
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program demonstrates how a floating-point
            // number can be displayed as currency.
            var monthlyPay = 5000.0;
            var annualPay = monthlyPay * 12;
            Console.WriteLine("Your annual pay is " + annualPay.ToString("C2"));
            Console.ReadLine();

            // Displays "Your annual pay is $60,000.00"
        }
    }
}
