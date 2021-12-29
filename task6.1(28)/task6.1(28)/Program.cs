using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._1_28_
{
    class Program
    {
        static void Main(string[] args)
        {
           var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(logic());
            Console.ReadKey();

             bool logic()
            {
                return (m / m == m) || (n / n == n);
            }
        }
    }
}
