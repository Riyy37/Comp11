using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp13
{
    /// <summary>
    /// Даны 8 различных чисел. 
    /// Определить максимальное из них, используя функцию определения максимального из двух чисел.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = InPut("Введите первое число = ");
            int b = InPut("Введите втрое число = ");
            int c = InPut("Введите третье число = ");
            int d = InPut("Введите четвертое число = ");
            int e = InPut("Введите пятое число = ");
            int f = InPut("Введите шестое число = ");
            int g = InPut("Введите седьмое число = ");
            int h = InPut("Введите восьмое число = ");

            Console.WriteLine($"Максимально число = {Max(a,b,c,d,e,f,g,h)}");
            Console.ReadKey();
        }
        static int Max(int a, int b, int c, int d, int e, int f, int g, int h)
        {
            return Math.Max(a, 
                   Math.Max(b, 
                   Math.Max(c,
                   Math.Max(d, 
                   Math.Max(e,
                   Math.Max(f,
                   Math.Max(g, h
                   )))))));
        }
        static int InPut(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        
    }
}
