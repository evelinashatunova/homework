using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7_28_
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Введите X");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine(f(x));
            Console.ReadKey();
        }
        static double f (double x)
        {
            double k;
            if (x < 0)
            {
                k = 0;
                return k;
            }
            else if (0 <= x && x <= 1)
            {
                k = Math.Sqrt(x);
                return k;
            }
            else
            {
                k = 1;
                return k;
            }
        }
    }
    }

