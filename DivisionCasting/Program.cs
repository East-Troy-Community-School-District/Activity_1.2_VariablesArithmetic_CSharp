/*
 * DivisionCasting
 * 12/5/2022
 * C#.NET I
 * 
 * Instructions
 * 1. Trace the program and predict its output. Run the program to
 *    check your prediction.
 * 2. Be prepared to discuss the following questions...
 *      a. When does C# perform a cast? Before or after operations?
 *      b. Why is if import to use a cast when dividing an integer by and
 *         integer?
 */

using System;

namespace DivisionCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2, y = 5;

            double result1 = y / x;
            double result2 = (double) (y / x);
            double result3 = (double) y / x;

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            decimal costPerUnit = 4.5M;
            int unitsSold = 5;
            decimal total = costPerUnit * unitsSold;
            Console.WriteLine("Total: $" + total);
        }
    }
}
