/*
 * Variables
 * 12/5/2022
 * C#.NET I
 * 
 * Instructions
 * 1. Trace the program and predict its output. Run the program to
 *    check your prediction.
 * 2. Be prepared to discuss the following questions...
 *      a. How do you declare and initialize a variable? What
 *         information must be provided?
 *      b. What information is stored in an int, double, decimal, bool
 *         char, and string?
 *      c. How do you declare multiple variables on one line?
 *      d. Why must you place an M at the end of 5482.45 on line 38?
 */

using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            const double TAX_RATE = 0.055;

            int a;
            a = 3;
            Console.WriteLine(a);

            int students = 5;
            double pH = 6.3;
            bool isAwake = true;
            decimal bankAccount = 5482.45M;
            char letter = 'F';
            string name = "Jimbo";
            Console.WriteLine("Ther are " + students
                + " students in the class.");
            Console.WriteLine(name + " is one of the students.");
            Console.WriteLine("He has $" + bankAccount);

            int b, c, d = 5;
            Console.WriteLine(d);
        }
    }
}
