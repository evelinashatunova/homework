using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_28_
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = GetResult();
            Console.WriteLine("GetResult = {0:F3}", x);
            Console.ReadKey();
                
        }
        private static double GetResult()
        {
            return CalculateExpression(1);

        }
        static double CalculateExpression(double y)
        {
            return (y + (y + (y + (y + Math.Sqrt(5)) / 11) / 7) / 2);
        }
    }
}
