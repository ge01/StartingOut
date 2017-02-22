using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0210
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program demonstrates variable reassignment.
            // Assign a value to the dollars variable.
            var dollars = 2.75;
            Console.WriteLine("I have {0} in my account.", dollars);

            // Reassign dollars so it references
            // a different value.
            dollars = 99.95;
            Console.WriteLine("I have {0} in my account.", dollars);

            Console.ReadLine();
        }
    }
}
