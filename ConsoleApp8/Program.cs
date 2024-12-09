using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    /// <summary>
    /// Создать метод, который будет вычислять площадь круга и длину окружности. 
    /// Вызывающий программный код должен передавать в качестве аргумента методу значение радиуса и печатать значение радиуса, 
    /// площади круга и длины окружности.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = InPut("r = ");
            double p = 1, s = 1;
            Function(r, ref p, ref s);
            Console.WriteLine($"Площадь = {p} ");
            Console.WriteLine($"Длина = {s} ");
            Console.ReadKey();
        }
        static int InPut(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Function(int r, ref double p, ref double s)
        {
            p = 2*Math.PI *r;
            s = Math.PI*Math.Pow (r, 2);
        }
    }
}
