using System;

namespace Task2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("4-Reqemli daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 1000 && a <= 9999)
            {
                Console.Write("Ededin 20%-i: ");
                double b = a * 20 / 100;
                Console.WriteLine(b);
                Console.Write("20%-i alinmis ededin 10%-i: ");
                Double c = b * 10 / 100;
                Console.Write(c);

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");

            }
            Console.ReadKey();
        }
    }
}
