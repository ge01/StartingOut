using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0213
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the user's name, age, and income.
            Console.Write("What is your name? ");
            var name = Console.ReadLine();

            Console.Write("What is your age? ");
            var age = Convert.ToUInt32(Console.ReadLine());

            Console.Write("What is your income? ");
            var income = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine();

            // Display the data.
            Console.WriteLine("Here is the data you entered:");
            Console.WriteLine("Name {0}", name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Income: {0}", income);

            Console.ReadLine();
        }
    }
}
