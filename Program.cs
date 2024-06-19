using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nitent_forms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Введите значение: x");
            x = double.Parse(Console.ReadLine());
            y = 4 * Math.Sin(x) * (5 * Math.Cos(x));
            Console.WriteLine("y = " + Math.Round(y, 2));
            Console.ReadLine();
        }
    }
}
