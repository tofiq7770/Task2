using System;

namespace Task2._10_on_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 dene 4-Reqemli eded daxil edilmelidir.");
            Console.Write("Birinci 4-Reqemli ededi daxil edin: ");
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
            Console.Write("Ikinci 4-Reqemli ededi daxil edin: ");
            double b = Convert.ToInt32(Console.ReadLine());
            if (b >= 1000 && b <= 9999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
            Console.Write("Uchuncu 4-Reqemli Ededi daxil edin: ");
            double c = Convert.ToInt32(Console.ReadLine());
            if (c >= 1000 && c <= 9999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
          

                Console.Write("Birinci ededin 1%-i: ");
                double d = a * 1 / 100;
                Console.WriteLine(d);
                Console.Write("Ikinci ededin 2%-i: ");
                double e = b * 2 / 100;
                Console.WriteLine(e);
                Console.Write("Uchuncu ededin 3%-i: ");
                double f = c * 3 / 100;
                Console.WriteLine(f);
                Console.Write("Ededlerin Ferqi ile 3-cu ededin 7%-nin toplanmasi: ");
                double g = c *7/100 ;
                double t = (d - e - f)+g;
                Console.WriteLine(t);

            
            Console.ReadKey();

        }
    }
}
