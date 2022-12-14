/*
 * Operators
 * 12/5/2022
 * C#.NET I
 * 
 * Instructions
 * 1. Trace the program and predict its output. Run the program to
 *    check your prediction.
 * 2. Be prepared to discuss the following questions...
 *      a. Were you surprised by the result of line 24?
 *      b. What is used in place of a variable?
 */

using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(2 + 4);
            Console.WriteLine(3 - 1);
            Console.WriteLine(2 * 5);
            Console.WriteLine(1 / 2);

            int x = 3;
            int y;
            y = 4;
            x = 10;
            y = x * 2 + 4;
            Console.WriteLine(x);

            Console.WriteLine(109 % 2);
            Console.WriteLine(529 % 10);
            Console.WriteLine(15 % 7);
        }
    }
}
