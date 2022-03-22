using System;

namespace Task2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci olaraq 4-Reqemli daxil edin: ");
            double a = Convert.ToInt32(Console.ReadLine());
            if (a >= 1000 && a <= 9999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
            Console.Write("Ikinci olaraq 7-Reqemli daxil edin: ");
            double b = Convert.ToInt32(Console.ReadLine());
            if (b >= 1000000 && b <= 9999999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
           
                Console.WriteLine("Birinci ededin 4 %-i: ");
                double c = a * 4 / 100;
                Console.WriteLine( c);
                Console.WriteLine("Ikinci ededin 9 %-i: ");
                double e = b * 9 / 100;
                Console.WriteLine(e);
                double f = (c + e) * 10 / 100;
                Console.WriteLine("Ededlerin ceminin 10 %-i: ");
                Console.WriteLine(f);

                Console.ReadKey();
        }
    }
}
