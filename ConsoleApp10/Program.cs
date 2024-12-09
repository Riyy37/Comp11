using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    /// <summary>
    /// Даны стороны двух треугольников. 
    /// Найти сумму их периметров и сумму их площадей. 
    /// (Определить вспомогательный метод для расчета периметра и площади треугольника по его сторонам.)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = InPut("a1 = ");
            int b1 = InPut("b1 = ");
            int c1 = InPut("c1 = ");

            int a2 = InPut("a2 = ");
            int b2 = InPut("b2 = ");
            int c2 = InPut("c2 = ");

            int perimetr1 = Perimeter(a1, b1, c1);
            int perimetr2 = Perimeter(a2, b2, c2);

            double area1 = Area(a1, b1, c1);
            double area2 = Area(a2, b2, c2);

            double area = area1 + area2;
            int perimetr = perimetr1 + perimetr2;

            Console.WriteLine($"Сумма периметров = {perimetr}, а сумма площадей = {area:f2}");
            Console.ReadKey();

        }

        static int InPut(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        static int Perimeter(int a, int b, int c)
        {
            return a + b + c;
        }
        static double Area(int a, int b, int c)
        {
            double p = Perimeter(a, b, c) / 2; 
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        

    }
}
