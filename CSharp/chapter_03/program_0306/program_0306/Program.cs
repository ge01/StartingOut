using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0306
{
    class Program
    {
        // This program demonstrates an argument being 
        // passed to a function
        static void Main(string[] args)
        {
            var value = 5;
            show_double(value);
            Console.ReadLine();
        }

        // The show_double function accepts an argument
        // and displays double its value.
        static void show_double(int number)
        {
            var result = number * 2;
            Console.WriteLine(result);
        }
    }
}
