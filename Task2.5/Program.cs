using System;

namespace Task2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("4-Reqemli daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 1000 && a <= 9999)
            {
                Console.Write("Ededin evveline 4 ve sonuna 44 elave etdikde: ");
                double b = (a * 100) + 4000044;
                Console.WriteLine(b);
                double c = b * 44 / 100;
                Console.Write("Ededin 44%-i: ");
                Console.WriteLine(c);

                
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
