using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    /// <summary>
    /// Написать программу определения площади пятиугольника с заданными координатами его вершин 
    /// (x1,y1), (x2,y2), (x3,y3), (x4,y4), (x5,y5) как сумму площадей трех треугольников. 
    /// Площадь треугольника, определенную по координатам вершин, рассчитать с помощью функции.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = InPut("Введите первую координату первой вершины = ");
            int y1 = InPut("Введите вторую координату первой вершины = ");

            int x2 = InPut("Введите первую координату второй вершины = ");
            int y2 = InPut("Введите вторую координату второй вершины = ");

            int x3 = InPut("Введите первую координату третьей вершины = ");
            int y3 = InPut("Введите вторую координату третьей вершины = ");

            int x4 = InPut("Введите первую координату четвёртой вершины = ");
            int y4 = InPut("Введите вторую координату четвёртой вершины = ");

            int x5 = InPut("Введите первую координату пятой вершины = ");
            int y5 = InPut("Введите вторую координату пятой вершины = ");

            double area1 = Area(x1, y1, x2, y2, x5, y5);
            double area2 = Area(x2, y2, x3, y3, x5, y5);
            double area3 = Area(x3, y3, x4, y4, x5, y5);

            double area = area1 + area2 + area3;

            Console.WriteLine($"Площадь пятиугольника = {area}");
            Console.ReadKey();
        }
        static double Area(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            return 0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2) );
        }
        static int InPut (string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
    }
}
