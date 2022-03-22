using System;

namespace Task2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("3-Reqemli daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 100 && a <= 999)
            {
                double b = (a * 10) + 7;
                Console.Write("Ededin sonuna 7 reqemini artirdiqda: ");   
                Console.WriteLine( b) ;
               
                Console.Write("Ededin 7%-i: ");
                double c = b * 7 / 100;
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
