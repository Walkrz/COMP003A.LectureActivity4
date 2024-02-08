/*
 * Author: Zachary Walker
 * Course: COMP-003A
 * Purpose: Code for Lecture Activity 4
 * Reference: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements
 */

namespace COMP003A.LectureActivity4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("for-loop statement");
            Console.WriteLine("".PadRight(50, '*'));

            int limit = 10;

            for (int counter = 0; counter < limit; counter++)
            {
                Console.WriteLine($"\tCurrent counter: {counter}");
            }

            Console.WriteLine("\n"); // new line
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("foreach statement");
            Console.WriteLine("".PadRight(50, '*'));

            string[] simpleArray = new string[] { "eleifend", "donec", "pretium", "vulputate", "sapien", "nec", "sagittis", "aliquam", "malesuada", "bibendum" };

            foreach (var item in simpleArray)
            {
                Console.WriteLine($"\tCurrent item: {item}");
            }

            Console.WriteLine("\n"); // new line
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("do-while statement");
            Console.WriteLine("".PadRight(50, '*'));

            int counter2 = 0;

            do
            {
                Console.WriteLine($"\tCurrent counter2: {counter2}");
                counter2++;
            } while (counter2 < 10);

            Console.WriteLine("\n"); // new line
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("while statement");
            Console.WriteLine("".PadRight(50, '*'));

            int counter3 = 0;

            while (counter3 < 20)
            {
                Console.WriteLine($"\tCurrent counter3: {counter3}");
                counter3 += 2;
            }

            Console.WriteLine("\n"); // new line
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("example for loop program that counter from 1-20 and checks if it is odd or even");
            Console.WriteLine("".PadRight(50, '*'));

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"\t{i}: even");
                }
                else
                {
                    Console.WriteLine($"\t{i}: odd");
                }
            }
        }
    }
}
