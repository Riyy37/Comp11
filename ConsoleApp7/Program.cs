using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    /// <summary>
    /// Составить программу, в результате которой величина а меняется значением с величиной b, а величина c — с величиной d.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = InPut("a = ");
            int b = InPut("b = ");
            int c = InPut("c = ");
            int d = InPut("d = ");

            Console.WriteLine($"Число до обмена: {a}\t{b}\t{c}\t{d} ");
            Swap(ref a, ref b);
            Swap(ref c, ref d);
            Console.WriteLine($"Число после обмена: {a}\t{b}\t{c}\t{d} ");
            Console.ReadKey();
        }
        static int InPut(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Swap(ref int x, ref int y)
        {
            int p = x;
            x = y;
            y = p;
        }

    }
}
