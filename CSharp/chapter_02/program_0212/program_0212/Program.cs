using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0212
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the user's first name.
            Console.WriteLine("Enter your first name: ");
            var firstName = Console.ReadLine();

            // Get the user's last name.
            Console.WriteLine("Enter your last name: ");
            var lastName = Console.ReadLine();

            // Print a greeting to the user.
            Console.WriteLine("Hello " + firstName + " " + lastName);
            Console.WriteLine();

            // Alternate code to print a greeting to the user.
            Console.WriteLine("Hello {0} {1}", firstName, lastName);
            Console.ReadLine();
        }
    }
}
