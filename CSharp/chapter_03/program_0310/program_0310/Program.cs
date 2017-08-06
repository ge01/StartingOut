using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0310
{
    class Program
    {   
        // This program demonstrates what happens when you 
        // change the value of a parameter.
        static void Main(string[] args)
        {
            var value = 99;
            Console.WriteLine("The value is {0}", value);
            change_me(value);
            Console.WriteLine("Back in main the value {0}", value);
            Console.ReadLine();
        }

        static void change_me(int arg)
        {
            Console.WriteLine("I am changing the value");
            arg = 0;
            Console.WriteLine($"Now the value is {arg}");
        }
    }
}
