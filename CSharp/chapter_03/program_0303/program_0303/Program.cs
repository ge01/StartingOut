using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0303
{
    class Program
    {
        // This program displays step-by-step instructions
        // for disassembling an Acme dryer.
        static void Main(string[] args)
        {
            // Display the start-up message.
            startup_message();
            Console.WriteLine("Press Enter to see Step 1.");
            // Display step 1.
            step1();
            Console.WriteLine("Press Enter to see Step 2.");
            // Display step 2.
            step2();
            Console.WriteLine("Press Enter to see Step 3.");
            // Display step 3.
            step3();
            Console.WriteLine("Press Enter to see Step 4.");
            // Display step 4.
            step4();
        }

        // The startup_message function displays the
        // program's initial message on the screen.
        static void startup_message()
        {
            Console.WriteLine("This program tells you how to");
            Console.WriteLine("disassemble an ACME laundry dryer.");
            Console.WriteLine("There are 4 steps in the process.");
            Console.WriteLine();
            Console.ReadLine();
        }

        // The step1 function displays the instructions
        // for step 1.
        static void step1()
        {
            Console.WriteLine("Step 1: Unplug the dryer and");
            Console.WriteLine("move it away from the wall.");
            Console.WriteLine();
            Console.ReadLine();
        }

        // The step1 function displays the instructions
        // for step 2.
        static void step2()
        {
            Console.WriteLine("Step 2: Remove the six screws");
            Console.WriteLine("from the back of the dryer.')");
            Console.WriteLine();
            Console.ReadLine();
        }

        // The step1 function displays the instructions
        // for step 1.
        static void step3()
        {
            Console.WriteLine("Step 3: Remove the back panel");
            Console.WriteLine("from the dryer");
            Console.WriteLine();
            Console.ReadLine();
        }

        // The step1 function displays the instructions
        // for step 1.
        static void step4()
        {
            Console.WriteLine("Step 4: Pull the top of the')");
            Console.WriteLine("dryer straight up.");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
