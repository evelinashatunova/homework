using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8._2_28_
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            Console.WriteLine("Введите количество товаров");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость товаров");
            decimal price = decimal.Parse(Console.ReadLine());

            for (int i = 0; i >=1; i++) 
            {
                Console.WriteLine(sum = amount * price);


            }
            Console.ReadKey();
        }
    }
}
