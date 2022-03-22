using System;

namespace Task2._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 dene 6-Reqemli eded daxil edilmelidir.");
            Console.Write("Birinci 6-Reqemli ededi daxil edin: ");
            double a = Convert.ToInt32(Console.ReadLine());
            if (a >= 100000 && a <= 999999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
            Console.Write("Ikinci 6-Reqemli ededi daxil edin: ");
            double b = Convert.ToInt32(Console.ReadLine());
            if (b >= 100000 && b <= 999999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
            Console.Write("Uchuncu 6-Reqemli ededi daxil edin: ");
            double c = Convert.ToInt32(Console.ReadLine());
            if (c >= 100000 && c <= 999999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
          
                Console.Write("Birinci ededin 10%-i: ");
                double d = a * 10 / 100;
                Console.WriteLine(d);
                Console.Write("ikinci ededin 10%-i: ");
                double e = b * 10 / 100;
                Console.WriteLine(e);
                Console.Write("Uchuncu ededin 10%-i: ");
                double f = c * 10 / 100;
                Console.WriteLine(f);


                Console.Write("Ededlerin ceminin 10%-i: ");
                
                double h = (d + e + f)*10/100;
                Console.WriteLine(h);



       
            Console.ReadKey();
        }
    }
}
