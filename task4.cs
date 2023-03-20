using System;

namespace ConsoleApp9
{
    internal class task4
    {
        static void Main(string[] args)
        {
            var num = 2853;
            int a = (num - num % 1000) / 1000;
            int b = ((num % 1000) - (num % 100)) / 100;
            int c = (((num % 1000) % 100) - ((num % 1000) % 100) % 10) / 10;
            int d = num % 10;
            int result = (d * 1000) + (c * 100) + (b * 10) + (a * 1);
            Console.WriteLine(result);
        }
    }
}