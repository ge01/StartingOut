using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0309
{
    class Program
    {
        // This program demonstrates passing two string
        // arguments to a function.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");
            var first_name = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            var last_name = Console.ReadLine();

            reverse_name(first_name, last_name);
            Console.ReadLine();
        }

        static void reverse_name(string first, string last)
        {
            Console.WriteLine("{0}, {1}", last, first);
        }
    }
}
