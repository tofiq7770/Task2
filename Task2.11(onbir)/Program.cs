using System;

namespace Task2._11_onbir_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 dene 5-Reqemli eded daxil edilmelidir.");
            Console.Write("Birinci 5-Reqemli daxil edin: ");
            double a = Convert.ToInt32(Console.ReadLine());
            
            if (a >= 10000 && a <= 99999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
            Console.Write("Ikinci 5-Reqemli daxil edin: ");
            double b = Convert.ToInt32(Console.ReadLine());
            
            if (b >= 10000 && b <= 99999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
            Console.Write("Uchuncu 5-Reqemli daxil edin: ");
            double c = Convert.ToInt32(Console.ReadLine());
           
            if (c >= 10000 && c <= 99999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
            Console.Write("Dorduncu 5-Reqemli daxil edin: ");
            double d = Convert.ToInt32(Console.ReadLine());
            if (d >= 10000 && d <= 99999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
           
                Console.Write("Birinci ve Uchuncu ededlerin cemi: ");
                double g = a + c;
                Console.WriteLine(g);
                Console.Write("Ikinci ve Dorduncu ededlerin cemi: ");
                double h = b + d;
                Console.WriteLine(h);
                Console.Write("Ededlerin hasilinden 3-cu Ededin 3%-nin ferqinin neticesi: ");
                double i = c*3/100;
                double t = (g * h) - i;
                Console.WriteLine(t);


            Console.ReadKey();

        }
    }
}
