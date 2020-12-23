using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChernobylApp2._3
{
    class Program //Средний уровень
    {
        static void Main(string[] args)
        {
            try
            {
                double y;
                Console.WriteLine("Введите число x для всех вариантов параметров: ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число (k), чтобы выбрать вариант параметров: ");
                double k = double.Parse(Console.ReadLine());
                if (k == 1)
                {
                    double a = 6;
                    Console.WriteLine($"Число a = {a}");
                    double b = 3.2;
                    Console.WriteLine($"Число b = {b}");
                    double z = (Math.Exp(1.5 * a * x));
                    Console.WriteLine($"Число z = {z}");
                    switch (k)
                    {
                        case 1:
                            y = (3.5 * a - 7.3 * b * x + Math.Pow(Math.Sin(z * x), 3));
                            Console.WriteLine("При х<-log|a| y равен: " + y);
                            break;
                        case 2:
                            y = Math.Pow(a, b) - Math.Pow(Math.Cos(a + z * x), 3);
                            Console.WriteLine("При -Log|a|<=x<b y равен: " + y);
                            break;
                        case 3:
                            y = Math.Sqrt(Math.Abs(Math.Tan(a) - x)) - Math.Pow(x, 2);
                            Console.WriteLine("При x>b у равен: " + y);
                            break;
                    }
                }
                else if (k == 2)
                {
                    double a = 3;
                    Console.WriteLine($"Число a = {a}");
                    double b = 6;
                    Console.WriteLine($"Число b = {b}");
                    double z = (Math.Exp(1.5 * a * x));
                    Console.WriteLine($"Число z = {z}");
                    switch (k)
                    {
                        case 1:
                            y = (3.5 * a - 7.3 * b * x + Math.Pow(Math.Sin(z * x), 3));
                            Console.WriteLine("При х<-log|a| y равен: " + y);
                            break;
                        case 2:
                            y = Math.Pow(a, b) - Math.Pow(Math.Cos(a + z * x), 3);
                            Console.WriteLine("При -Log|a|<=x<b y равен: " + y);
                            break;
                        case 3:
                            y = Math.Sqrt(Math.Abs(Math.Tan(a) - x)) - Math.Pow(x, 2);
                            Console.WriteLine("При х>b у равен: " + y);
                            break;
                    }
                }
                else if (k == 3)
                {
                    double a = 2.7;
                    Console.WriteLine($"Число a = {a}");
                    double b = 1.8;
                    Console.WriteLine($"Число b = {b}");
                    double z = (Math.Exp(1.5 * a * x));
                    Console.WriteLine($"Число z = {z}");
                    switch (k)
                    {
                        case 1:
                            y = (3.5 * a - 7.3 * b * x + Math.Pow(Math.Sin(z * x), 3));
                            Console.WriteLine("При х<-log|a| y равен: " + y);
                            break;
                        case 2:
                            y = Math.Pow(a, b) - Math.Pow(Math.Cos(a + z * x), 3);
                            Console.WriteLine("При -Log|a|<=x<b y равен: " + y);
                            break;
                        case 3:
                            y = Math.Sqrt(Math.Abs(Math.Tan(a) - x)) - Math.Pow(x, 2);
                            Console.WriteLine("При х>b у равен: " + y);
                            break;
                    }
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
