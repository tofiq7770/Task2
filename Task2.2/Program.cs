using System;

namespace Task2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("3-Reqemli daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 100 && a <=999)
            {
                int b = a * 1001;
                Console.WriteLine(b);
                //ve ya
               // string b = ($"{a}{a}");
              //  Console.WriteLine(b);
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
