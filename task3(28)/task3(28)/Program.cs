using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_28_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите x");
            double y;
            Console.WriteLine(value: y = conclusion);
            Console.ReadKey();

        }
       
        static double conclusion
        {
            get

            {
                var x = double.Parse(Console.ReadLine());
                double y;
                return y = Math.Atan((1 + (Math.Pow(x, 2)) / 2));
            }

        }
    }
}
