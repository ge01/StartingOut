using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0216
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get three test scores and assign them to the 
            // test1, test2, and test3 variables.
            Console.Write("Enter the first test score: ");
            float test1 = float.Parse(Console.ReadLine());

            Console.Write("Enter the second test score: ");
            float test2 = float.Parse(Console.ReadLine());

            Console.Write("Enter the third test score: ");
            float test3 = float.Parse(Console.ReadLine());

            // Calculate the average of the three scores
            // and assign the result to the average variable.
            var average = (test1 + test2 + test3) / 3.0;

            // Display the average.
            Console.WriteLine();
            Console.WriteLine("The average score is " + average.ToString("F2"));
            Console.ReadLine();
        }
    }
}
