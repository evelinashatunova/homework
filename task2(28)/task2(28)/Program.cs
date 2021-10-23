using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_28_
{
    class Program

    {
        public static int AriphmeticProgress(int memb, int dif, int n)
        {
            if (n > 0)
            { memb = dif + AriphmeticProgress(memb, dif, n - 1); }
            return memb;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите разность");
            int differ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первый член прогрессии");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ответ = {0}", AriphmeticProgress(first, differ, a - 1));
            Console.ReadLine();




        }
    }
}
