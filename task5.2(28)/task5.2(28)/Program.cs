using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5._2_28_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "обитель";
            string result = str.Substring(3, 3)
                + str.Substring(0, 1);
            string res = str.Substring(1, 1)
                + str.Substring(0, 1)
                + str.Substring(5, 2);
            Console.WriteLine(result);
            Console.WriteLine(res);
            Console.ReadKey();
                
                
        }
    }
}
