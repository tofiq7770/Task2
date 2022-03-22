using System;

namespace Task2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 dene 5-Reqemli eded daxil edilmelidir.");
            Console.Write("Birinci 5-Reqemli daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
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
            int b = Convert.ToInt32(Console.ReadLine());
            if (b >= 10000 && b <= 99999)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert duzgun icra edilmeyib");
                return;
            }

                Console.Write("Birinci ve Ikinci Ededin cemi: ");
                double c = a + b;
                Console.WriteLine(c);
                Console.Write("Cemin Evveline Sonuna 5 reqemini artirdiqda: ");
                if (a+b>100000)
                {
                    double d = (c * 10) + 50000005;
                    Console.WriteLine(d);
                    Console.Write("Alinmish neticenin 5 %-i: ");
                    double e = d * 5 / 100;
                    Console.WriteLine(e);
                }
                else
                {
                    double d = (c * 10) + 5000005;
                    Console.WriteLine(d);
                    Console.Write("Alinmish neticenin 5 %-i: ");
                    double e = d * 5 / 100;
                    Console.WriteLine(e);
                }
           
            Console.ReadKey();  
        }
    }
}
