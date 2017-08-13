using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0401
{
    class Program
    {
        // This program gets three test scores and displays
        // their average. It congratulates the user if the 
        // average is a high score

        static void Main(string[] args)
        {
            int HIGH_SCORE = 95;

            // Get the three test scores.
            Console.Write("Enter the score for test 1: ");
            var test1 = float.Parse(Console.ReadLine());

            Console.Write("Enter the score for test 2: ");
            var test2 = float.Parse(Console.ReadLine());

            Console.Write("Enter the score for test 3: ");
            var test3 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            // Calculate the average test score.
            var average = (test1 + test2 + test3) / 3;

            // Print the average.
            Console.WriteLine("The average score is {0}", average.ToString("F2"));
            
            // If the average is a high score,
            // congratulate the user.
            if (average >= HIGH_SCORE)
            {
                Console.WriteLine("Congratulations!");
                Console.WriteLine("That is a greate average!");
            }

            Console.ReadLine();
        }
    }
}
