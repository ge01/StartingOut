using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0302
{
    class Program
    {
        // This program has two functions. First we
        // define the main function.
        static void Main(string[] args)
        {
            Console.WriteLine("I have a message for you.");
            message();
            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }

        // Next we define the message function.
        static void message()
        {
            Console.WriteLine("I am Arthur,");
            Console.WriteLine("King of the Britons.");
        }        
    }
}
