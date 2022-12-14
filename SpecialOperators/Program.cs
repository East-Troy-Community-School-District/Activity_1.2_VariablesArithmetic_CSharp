/*
 * SpecialOperators
 * 12/5/2022
 * C#.NET I
 * 
 * Instructions
 * 1. Trace the program and predict its output. Run the program to
 *    check your prediction.
 * 2. Be prepared to discuss the following questions...
 *      a. How do the augmented assignment operators work?
 *      b. How do the increment and decrement operators work?
 *      c. What happens change line 23 to int x;?
 */

using System;

namespace SpecialOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;

            x += 3;
            Console.WriteLine(x);
            x -= 5;
            Console.WriteLine(x);
            x *= 5;
            Console.WriteLine(x);

            x++;
            Console.WriteLine(x);
            x--;
            Console.WriteLine(x);
        }
    }
}
