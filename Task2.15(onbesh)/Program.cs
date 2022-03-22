using System;

namespace Task2._15_onbesh_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7 dene eded daxil edilmelidir.");
            Console.Write("Birinci olaraq 3-Reqemli eded daxil edin: ");
            double a = Convert.ToInt32(Console.ReadLine());
            if (a >= 100 && a <= 999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
            Console.Write("Ikinci olaraq 3-Reqemli eded daxil edin: ");
            double b = Convert.ToInt32(Console.ReadLine());
            if (b >= 100 && b <= 999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
            Console.Write("Uchuncu olaraq 4-Reqemli eded daxil edin: ");
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
            Console.Write("Dorduncuolaraq 4-Reqemli eded daxil edin: ");
            double d = Convert.ToInt32(Console.ReadLine());
            if (d >= 1000 && d <= 9999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
            Console.Write("Beshinci olaraq 5-Reqemli eded daxil edin: ");
            double e = Convert.ToInt32(Console.ReadLine());
            if (e >= 10000 && e <= 99999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
            Console.Write("Altinci olaraq 5-Reqemli eded daxil edin: ");
            double f = Convert.ToInt32(Console.ReadLine());
            if (f >= 10000 && f <= 99999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;

            }
            Console.Write("Yeddinci  olaraq 6-Reqemli eded daxil edin: ");
            double h = Convert.ToInt32(Console.ReadLine());
            if (h >= 100000 && h <= 999999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
            Console.Write("Bir--3-reqemli ededlerin cemi ile 4-reqemli ededlerin hasilinin cemi: ");
            double q = (a + b)+(c*d);
            Console.WriteLine(q);
            Console.Write("Iki--Bu neticenin sonuna 7 reqemini artirdiqda: ");
            double r = (q * 10) + 7;
            Console.WriteLine(r);
            Console.Write("Uc--Bu neticenin sonuna 7 artirilmish formasi ile 5-reqemlilerin hasilinin cemi:  ");
            double g = e * f;
            double o = r + g;
            Console.WriteLine(o);
            Console.Write("Dord--3-reqemli ededlerin hasilinin sonuna 1 reqemini artirdiqda: ");
            double p = (a * b);
            double l = (p * 10) + 1;
            Console.WriteLine(l);
            Console.Write("Besh--Uc ve Dorduncu neticelerin ferqi: ");
            double w = o - l;
            Console.WriteLine(w);
            Console.Write("Alti--Alinmish netice ile 6-reqemli ededin cemi: ");
            double x = w + h;
            Console.WriteLine(x);
            Console.Write("Yeddi--Altinci neticeden 3 ve 4 reqemli ededlerin ceminin ferqi:");
            double y = a + b + c + d;
            double z = x - y;
            Console.WriteLine(z);
            Console.WriteLine("Sekkiz--Yeddinci neticenin 18%-i sonra 3%-i sonra 1%-i: ");
            Console.Write("  18%=");
            double v = z * 18 / 100;
            Console.WriteLine(v);
            Console.Write("  3%=");
            double i = v * 3 / 100;
            Console.WriteLine(i);
            Console.Write("  1%=");
            double m = i * 1 / 100;
            Console.WriteLine(m);
            Console.Write("Doqquz--1%-i tapilmish netice ile 5 reqemli ededlerin cemi: ");
            double n = e + f;
            double t = n + m;
            Console.WriteLine(t);

            Console.ReadKey();


        }
    }
}
