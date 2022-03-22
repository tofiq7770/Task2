using System;

namespace Task2._13_onuc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci olaraq 5-Reqemli daxil edin: ");
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
            Console.Write("Ikinci olaraq 5-Reqemli daxil edin: ");
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
            Console.Write("Uchuncu olaraq 5-Reqemli daxil edin: ");
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
            Console.Write("Dorduncu olaraq 3-Reqemli daxil edin: ");
            double d = Convert.ToInt32(Console.ReadLine());
            if (d >= 100 && d <= 999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
            Console.Write("Beshinci olaraq 3-Reqemli daxil edin: ");
            double e = Convert.ToInt32(Console.ReadLine());
            if (e >= 100 && e <= 999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }
            if (a >= 10000 && a <= 99999 && b >= 10000 && b <= 99999
             && c >= 10000 && c <= 99999 && d >= 100 && d <= 999 
             && e >= 100 && e <= 999)
            {
                Console.Write("Birinci 5 reqemlinin 5%-i: ");
                double t = a * 5 / 100;
                Console.WriteLine(t);
                Console.Write("Ikinci 5 reqemlinin 5%-i: ");
                double y = b * 5 / 100;
                Console.WriteLine(y);
                Console.Write("Uchuncu 5 reqemlinin 5%-i: ");
                double f = c * 5 / 100;
                Console.WriteLine(f);
                Console.Write("5 reqemlilerin 5%-nin hasili: ");
                double g = t * y * f;
                Console.WriteLine(g);
                Console.Write("Birinci 3 reqemlinin 3%-i: ");
                double q = d * 3 / 100;
                Console.WriteLine(q);
                Console.Write("Ikinci 3 reqemlinin 3%-i: ");
                double u = e * 3 / 100;
                Console.WriteLine(u);
                Console.Write("3 reqemlilerin cemi: ");
                double w = u + q;
                Console.WriteLine(w);
                Console.Write("5 reqemlilerin 5%-nin hasili ile 3 reqemlilerin 3%-nin cemi: ");
                double x = g + w;
                Console.WriteLine(x);
                Console.Write("Cemin 10%-i: ");
                double z = x*10/100;
                Console.WriteLine(z);  



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
