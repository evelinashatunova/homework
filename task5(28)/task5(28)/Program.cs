using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_28_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите текст на английском языке");
            var text = Console.ReadLine();
            text = text.ToUpperInvariant();
            Console.WriteLine($"транслитерация текста:" + TransliterateText( text));
            Console.ReadKey();
        }
        static string TransliterateText(string  text)
        {
            text = text.Replace("A", "4");
            text = text.Replace("B", "8");
            text = text.Replace("C", "(");
            text = text.Replace("D", "|)");
            text = text.Replace("E", "3");
            text = text.Replace("F", "|=");
            text = text.Replace("G", "6");
            text = text.Replace("H", "|-|");
            text = text.Replace("I", "!");
            text = text.Replace ("J", ")");
            text = text.Replace ("K", "|<");
            text = text.Replace("L", "1");
            text = text.Replace("M", "|V|");
            text = text.Replace("N", "|/|");
            text = text.Replace("O", "0");
            text = text.Replace("P", "|>");
            text = text.Replace("Q", "R");
            text = text.Replace("R", "|2");
            text = text.Replace("S", "5");
            text = text.Replace("T", "7");
            text = text.Replace("U", "|_|");
            text = text.Replace("V", "/");
            text = text.Replace("W", "VV");
            text = text.Replace("X", "><");
            text = text.Replace("Y", "'/");
            text = text.Replace("Z", "2");
            return text;




        }
    }
}
