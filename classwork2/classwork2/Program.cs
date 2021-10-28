using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите координату x");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine("введите координату y");
            var y = double.Parse(Console.ReadLine());
            
            if (x == 0)
            {
                if (y == 0)
                {
                    Console.WriteLine($"точка совпадает с началом координат");
                }
                else
                {
                    Console.WriteLine($"njxrf({x};{y})лежит на оси oy");
       
                }
            }
            else
            {
                if (y == 0)

                {
                    Console.WriteLine($"точка({x};{y}) лежит на оси ox");
                }
                else
                {
                    if (x>0)
                    {
                        if(y>0)
                        {
                            Console.WriteLine($"точка({x};{y}) лежит в I квандранте");
                        }
                        else
                        {
                            Console.WriteLine($"точка ({x};{y}) лежит в IV квадранте");

                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
