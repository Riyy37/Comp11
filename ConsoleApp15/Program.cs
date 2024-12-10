using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
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

            double AB = Distance(x1, y1, x2, y2);
            double BC = Distance(x2, y2, x3, y3);
            double CA = Distance(x3, y3, x1, y1);

            if (AB == BC && BC == CA)
                Console.WriteLine("Равносторонний");
            else if (AB == BC)
                Console.WriteLine("Равнобедренный");
            else if (CA == BC)
                Console.WriteLine("Прямоугольный");



            Console.ReadKey();
        }
        static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
                               
        static int InPut(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
    }
}
