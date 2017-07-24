using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0308
{
    class Program
    {
        // This program demonstrates a function that accepts 
        // two arguments.
        static void Main(string[] args)
        {
            Console.WriteLine("The sum of 12 and 45 is");
            show_sum(12, 45);
            Console.ReadLine();
        }

        // The show_sum function accepts two arguments
        // and displays their sum.
        static void show_sum(int num1, int num2)
        {
            var result = num1 + num2;
            Console.WriteLine(result);
        }
    }
}
