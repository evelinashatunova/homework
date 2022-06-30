using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\эва\Desktop\test.txt";
            int rowCount = File.ReadAllLines(path).Length;
            string[] boxes = new string[rowCount];
            int count = 0;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    boxes[count] = line;
                    count++;
                }
            }
            int chCount = 0;

            //Вывод начального положения ящиков
            Console.WriteLine("Start shit:\n");
            for (int i = 0; i < rowCount; i++)
            {
                Console.WriteLine("Box row " + (i + 1) + ":" + boxes[i]);
            }

            //Перестановка всех ящиков в первый
            for (int i = 1; i < rowCount; i++)
            {
                boxes[0] = boxes[0] + boxes[i];
                chCount = chCount + boxes[i].Length;
                boxes[i] = "";
            }

            //Переменные, с помощью которых будут перестановки
            int strLen = boxes[0].Length;
            string arBuf = boxes[0];

            //Перестановка всех ящиков по своим местам, кроме тех, у которых 1 номер, они во 2 стопку
            for (int i = 1; i <= strLen; i++)
            {
                if (arBuf.Substring(strLen - i) == "1")
                {
                    boxes[1] = boxes[1] + "1";
                }
                else
                {
                    boxes[Convert.ToInt32(arBuf.Substring(strLen - i)) - 1] = boxes[Convert.ToInt32(arBuf.Substring(strLen - i)) - 1] + arBuf.Substring(strLen - i);
                }
                chCount++;
                arBuf = arBuf.Substring(0, strLen - i);
            }
            boxes[0] = "";

            strLen = boxes[1].Length;
            arBuf = boxes[1];

            //Перестановка ящиков с 1 номером в 1 стопку, а со 2 номером в 3
            for (int i = 1; i <= strLen; i++)
            {
                if (arBuf.Substring(strLen - i) == "1")
                {
                    boxes[0] = boxes[0] + "1";
                }

                else
                {
                    boxes[2] = boxes[2] + "2";
                }
                chCount++;
                arBuf = arBuf.Substring(0, strLen - i);
            }


            boxes[1] = "";

            arBuf = boxes[2];
            strLen = boxes[2].Length;
            int f = 1;

            //перестановка ящиков с номером 2 в стопку 2
            while (arBuf.Substring(strLen - f) != "3")
            {
                boxes[1] = boxes[1] + "2";
                arBuf = arBuf.Substring(0, strLen - f);
                f++;
                chCount++;
            }

            boxes[2] = arBuf;
            Console.WriteLine("Change count: " + chCount + "\n");

            //вывод финального положения ящиков
            Console.WriteLine("\nFinish shit:\n");
            for (int i = 0; i < rowCount; i++)
            {
                Console.WriteLine("Box row " + (i + 1) + ":" + boxes[i]);
            }
            Console.ReadLine();
    }
    }
}
