using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("В листопаде, яркое");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"В листопаде, яркое,
Что за чудо, спросим? -
На дары богатое
Время года осень.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}
