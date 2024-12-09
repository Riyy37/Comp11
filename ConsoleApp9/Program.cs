using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    /// <summary>
    /// Ввести три целых числа и вывести их в порядке возрастания значений.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = Input("a = ");
            int b = Input("b = ");
            int c = Input("c = ");
            Sort(ref a, ref b, ref c);
            Output(a, b, c);

            Console.ReadKey();
        }


        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }


        static void Sort(ref int a, ref int b, ref int c)
        {
            if (a > b) (a, b) = (b, a);
            if (b > c) (b, c) = (c, b);
            if (a > b) (a, b) = (b, a);
        }


        static void Output(int a, int b, int c)
        {
            Console.WriteLine($"Числа в порядке возрастания = {a}, {b}, {c}");
        }
    }
}
