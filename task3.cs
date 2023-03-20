using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 51;
            if (num > 0)
            {
                Console.WriteLine(num % 10);
            }
            else
            {
                Console.WriteLine("This number is not a natural number!");
            }
        }
    }
}