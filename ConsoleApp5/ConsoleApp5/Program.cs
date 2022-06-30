using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = new string[2];
            string writePath = @"C:\Users\эва\Desktop\moves.txt";
            string text = "Success";
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(text);
            }
            Console.ReadLine();
        }
    }
    }

