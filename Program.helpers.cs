using System;

namespace PetsName
{
        partial class Program
    {
        static int InputNumber(string text)
        {
            Console.WriteLine(text);
            var args = Console.ReadLine();

            if (!int.TryParse(args, out var number))
            {
                Console.WriteLine($"Oops! {args} doesn't look like a number. Try again!");
                InputNumber(text);
            }

            return number;
        }

        static void PrintNumber(int number)
        {
            Console.Write(number.ToString());
        }

        static void PrintWord(string word)
        {
            Console.Write(word);
        }

        static void PrintSpace()
        {
            Console.Write(" ");
        }

        static void PrintLine()
        {
            Console.WriteLine();
        }
    }
}
