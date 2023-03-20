namespace ConsoleApp7
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            int num = 236;
            int a = (num - (num % 100)) / 100;
            int b = ((num % 100) - (num % 10)) / 10;
            int c = num % 10;
            Console.WriteLine(a + b + c);
        }
    }
}