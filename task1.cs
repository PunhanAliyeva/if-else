using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 21;
            int num2 = 7;
            char[] charArray = { '+', '-', '*', '/' };
            char charvariable = '/';
            switch ("char"){
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
        }
    }
}