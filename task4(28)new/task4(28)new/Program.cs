using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_28_new
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = function(function(function(1 + Math.Sqrt(5), 11), 7), 2);
            Console.WriteLine(Math.Round(x, 3));
            Console.ReadKey();
        }
        static double function(double k1, double k2)
        {
            return 1 +( k1 / k2);
        }
    }
}
