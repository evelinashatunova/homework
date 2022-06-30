using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = new string[2];
            string path = @"C:\Users\эва\Desktop\test.txt";//Write down your path
            int i = 0;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                   s [i] = line;
                    i++;
                }
            }
            Console.WriteLine(s[1]);
            Console.ReadLine();
        }
    }
}
