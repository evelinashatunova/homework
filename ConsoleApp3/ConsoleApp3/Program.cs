using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path_base = @"C:\Users\эва\Desktop\Текстовый документ.txt";
            int count = System.IO.File.ReadAllLines(path_base).Length;
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
