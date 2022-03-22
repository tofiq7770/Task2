using System;

namespace Task2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("5-Reqemli daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 10000 && a <= 99999)
            {
                Console.WriteLine("Ededin 18%-i");
                double c = a * 18/100;
                Console.WriteLine(c);
                Console.WriteLine("Ededin 18%-nin 3%-i");
                double d = c * 3 / 100;
                Console.WriteLine(d);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");

            }
            
        }
    }
}
