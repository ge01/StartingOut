using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0305
{
    class Program
    {
        // This program demonstrates two functions that
        // have local variables with the same name.
        static void Main(string[] args)
        {
            // Call the texas function.
            texas();

            // Cal the california function.
            california();

            Console.ReadLine();
        }

        // Definition of the texas function. It creates
        // a local variable named birds.
        static void texas()
        {
            int birds = 5000;
            Console.WriteLine("texas has " + birds + " birds.");
        }

        // Definition of the california function. It also
        // creates a local variable named birds.
        static void california()
        {
            int birds = 8000;
            Console.WriteLine($"california has {birds} birds.");
        }        
    }
}
