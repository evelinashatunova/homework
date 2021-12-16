using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3New_28_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(GetFunction(x));
            Console.ReadKey();
        }
        static double GetFunction(double x)
        {
            double y;
            return y = Math.Atan((1 + (Math.Pow(x, 2)) / 2));
        }
    }
}
