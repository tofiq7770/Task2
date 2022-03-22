using System;

namespace Task2._12_oniki_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 dene 6-Reqemli eded daxil edilmelidir.");
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
            double d = Convert.ToInt32(Console.ReadLine());
            if (d >= 100000 && d <= 999999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
            if (a >= 100000 && a <= 999999 && b >= 100000 && b <= 999999 && c >= 100000 
                && c <= 999999 && d >= 100000 && d <= 999999)
            {
                Console.Write("Birinci ededin 10%-i: ");
                double q = a * 10 / 100;
                Console.WriteLine(q);
                Console.Write("ikinci ededin 10%-i: ");
                double e = b * 10 / 100;
                Console.WriteLine(e);
                Console.Write("Uchuncu ededin 10%-i: ");
                double f = c * 10 / 100;
                Console.WriteLine(f);
                Console.Write("Dorduncu ededin 10%-i: ");
                double y = d * 10 / 100;
                Console.WriteLine(y);


                Console.Write("Ededlerin 10%-nin cemi: ");
                double w = (q + e + f + y);
                Console.WriteLine(w);

                Console.Write("Birinci ededin 15%-i: ");
                double u = a * 10 / 100;
                Console.WriteLine(q);
                Console.Write("ikinci ededin 15%-i: ");
                double i = b * 10 / 100;
                Console.WriteLine(e);
                Console.Write("Uchuncu ededin 15%-i: ");
                double k = c * 10 / 100;
                Console.WriteLine(f);
                Console.Write("Dorduncu ededin 15%-i: ");
                double l = d * 10 / 100;
                Console.WriteLine(y);
                Console.Write("Ededlerin 15%-nin cemi: ");
                double m = (u + i + k + l);
                Console.WriteLine(m);

                Console.Write("10 ve 15%-i tapilmish cemlerin hasili: ");
                double p = m + y;
                Console.WriteLine(p);
                Console.Write("Hemin hasilin 10%-i: ");
                double j = p * 10 / 100;
                Console.WriteLine(j);
                Console.Write("10%-i tapilmish hasilin 11%-i: ");
                double s = j * 11/ 100;
                Console.WriteLine(s);






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
