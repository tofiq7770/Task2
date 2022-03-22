using System;

namespace Task2._14_ondord_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6 dene 6-Reqemli eded daxil edilmelidir.");
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
            Console.Write("Dorduncu 6-Reqemli ededi daxil edin: ");
            double e = Convert.ToInt32(Console.ReadLine());
            if (e >= 100000 && e <= 999999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
            Console.Write("Beshinci 6-Reqemli ededi daxil edin: ");
            double s = Convert.ToInt32(Console.ReadLine());
            if (s >= 100000 && s <= 999999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
            Console.Write("Altinci 6-Reqemli ededi daxil edin: ");
            double f = Convert.ToInt32(Console.ReadLine());
            if (f >= 100000 && f <= 999999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
            Console.Write("Butun ededlerin cemi: ");
            double g = a + b + c + f + s + e;
            Console.WriteLine(g);
            Console.Write("Birinci ve ucuncu ededi birbirine birleshmesi: ");
            double h = (a * 1000000) + c;
            Console.WriteLine(h);
            Console.Write("Birinci neticeden Ikinci neticenin ferqi: ");
            double r = (g - h);
            Console.WriteLine(r);
            Console.Write("Ferqin 10%-i: ");
            double t = r * 10 / 100;
            Console.WriteLine(t);
            Console.Write("10%-i alinmish ededin uzerine 5-ci ve 6-ci ededleri geldikde: ");
            double j = s + f + t;
            Console.WriteLine(j);
            Console.Write("Bu ededin 11%-i: ");
            double k = j * 11 / 100;
            Console.WriteLine(k);

            Console.ReadKey();


        }
    }
}
