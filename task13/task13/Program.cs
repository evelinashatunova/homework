using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowCount = 4;
            int chCount = 0;
            string[] boxes = new string[rowCount];
            boxes[0] = "1423434";
            boxes[1] = "13212";
            boxes[2] = "3122134";
            boxes[3] = "4211434";

            Console.WriteLine("Start shit:\n");

            for (int i = 0; i < rowCount; i++)
            {
                Console.WriteLine("Box row " + (i + 1) + ":" + boxes[i]);
            }

            for (int i = 1; i < rowCount; i++)
            {
                boxes[0] = boxes[0] + boxes[i];
                chCount = chCount + boxes[i].Length;
                boxes[i] = "";
            }

            int strLen = boxes[0].Length;
            string arBuf = boxes[0];

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
            while (arBuf.Substring(strLen - f) != "3")
            {
                boxes[1] = boxes[1] + "2";
                arBuf = arBuf.Substring(0, strLen - f);
                f++;
                chCount++;
            }

            boxes[2] = arBuf;
            Console.WriteLine("Change count: " + chCount + "\n");
            Console.WriteLine("\nFinish shit:\n");
            for (int i = 0; i < rowCount; i++)
            {
                Console.WriteLine("Box row " + (i + 1) + ":" + boxes[i]);
            }
            Console.ReadLine();
        }

    }
}
