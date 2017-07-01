using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0304
{
    class Program
    {
        // Definition of the main function.
        static void Main(string[] args)
        {
            get_name();
            Console.WriteLine("Hello", name);   // This causes an error
        }

        // Definition of the get_name function.
        static void get_name()
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
        }
    }
}
