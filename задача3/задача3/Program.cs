using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача3
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("введите номер года н.э");
            var year = int.Parse(Console.ReadLine());
             var yearNumber = (year - 1984) % 60;

            if (yearNumber < 0)
                yearNumber += 60;
            Console.WriteLine($"{year} г. - год {GetColor(yearNumber % 5)}{ GetAnimal(yearNumber % 12)}");
            Console.WriteLine(year);
            Console.ReadKey();
        }
        static string GetAnimal(int number)
        {
            switch(number)
                {
                case 0:
                    return "ой крысы";
                case 1:
                    return "ой коровы";
                case 2:
                    return " ого тигра";
                        case 3:
                    return "его зайца";
                case 4:
                    return "ого дракона";
                case 5:
                    return "ой змеи";
                case 6:
                    return "ой лошади";
                case 7:
                    return "ой овцы";
                case 8:
                    return "ой обезьяны";
                case 9:
                    return "ой курицы";
                case 10:
                    return "ой собаки";
                default:
                    return "ой свиньи";
                    



            }
        }
        static string GetColor(int number)
        {
            if (number == 0)
                return "зелен";
            else if (number == 1)
                return "красн";
            else if (number == 3)
                return "бел";
            else
                return "черн";


        }
    }
}
