using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._2_28_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату x");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y");
            var y = double.Parse(Console.ReadLine());

            GetCoordinate();
            Console.ReadKey();
           
             void GetCoordinate()
            {
                
                if (x >= -1 && y >= -2)
                {
                    Console.WriteLine($"Точка ({x};{y}) принадлежит к указанной области");
                }
                else if (x <= -3 && y >= -2)
                {
                    Console.WriteLine($"Точка ({x};{y}) принадлежит к указанной области");
                }
                else
                {
                    Console.WriteLine($"Точка ({x};{y}) не принадлежит к указанной области");
                }
                
            }      
        }
    }
}
