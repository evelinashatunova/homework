using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите начальное значение аргумента");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine("введите значение шага");
            var d = double.Parse(Console.ReadLine());
            Console.WriteLine("введите число строк таблицы");
            var n = double.Parse(Console.ReadLine());
            Console.WriteLine(" x | x^2");
            Console.WriteLine(new string('-', 15));

            for (var i = 0; i < n; i++) 
            {
                Console.WriteLine($"{x,5:F2} | {x * x:F3}");
                x += d;
            }
            
            
            
            
            Console.ReadKey();




        }
    }
}
