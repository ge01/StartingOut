using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0217
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the number of seconds from the user.
            Console.Write("Enter a number of seconds: ");
            var totalSeconds = float.Parse(Console.ReadLine());

            // Get the number of hours.
            var hours = (int)(totalSeconds / 3600);

            // Get the number of minutes.
            var minutes = (int)(totalSeconds / 60) % 60;

            // Get the number of seconds.
            var seconds = totalSeconds % 60;

            // Display the results.
            Console.WriteLine();
            Console.WriteLine("Here is the time in hours, minutes, and seconds: ");
            Console.WriteLine("Hours: " + hours.ToString("F1"));
            Console.WriteLine("Minutes: {0}", minutes.ToString("F1"));
            Console.WriteLine("Seconds: " + seconds.ToString("F1"));
            Console.ReadLine();
        }
    }
}
