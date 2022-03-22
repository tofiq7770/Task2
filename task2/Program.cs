using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("4-Reqemli daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a>=1000 && a<=9999)
            {
                int b = (a*10) + 700008;
                Console.WriteLine(b);
                //ve ya
               // string b = ($"7{a}8");
                //Console.WriteLine(b);
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
