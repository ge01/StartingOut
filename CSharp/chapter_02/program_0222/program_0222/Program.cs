using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0222
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program displays the following
            // floating-point numbers in a column
            // with their decimal points alligned.
            var num1 = 127.899;
            var num2 = 3465.148;
            var num3 = 3.776;
            var num4 = 264.821;
            var num5 = 88.081;
            var num6 = 799.999;

            // Right-align a currency value in a 
            // 14 -character field
            Console.WriteLine("{0,14:C2}", num1);
            Console.WriteLine("{0,14:C2}", num2);
            Console.WriteLine("{0,14:C2}", num3);
            Console.WriteLine("{0,14:C2}", num4);
            Console.WriteLine("{0,14:C2}", num5);
            Console.WriteLine("{0,14:C2}", num6);
            Console.ReadLine();

            //12345678901234
            // Output displayed below
            //       $127.90
            //     $3,465.15
            //         $3.78
            //       $264.82
            //        $88.08
            //       $800.00

        }
    }
}
