using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Medicine
    {
        public string Name;
        public readonly string Code;
        public Omitting Omit;
        public string Company;
        public double Price
        {
            get
            {
                return Price;
            }
            set
            {
                if (value >= 0)
                    Price = value;
            }
        }

        public int Quantity
        {
            get
            {
                return Quantity;
            }
            set
            {
                if (value >= 0)
                    Quantity = value;
            }
        }

        public Medicine(string name, string code, Omitting omit, string company)
        {
            Name = name;
            Code = code;
            Omit = omit;
            Company = company;
        }
        public override string ToString()
        {
            return $"{Name} {Code}";
        }
        public void PrintInfo()
        {
            Console.WriteLine(this);

            var omit = "";
            switch (Omit)
            {
                case Omitting.NoPerscription:
                    omit = "отпускается без рецепта";
                    break;
                case Omitting.Perscription:
                    omit = "отпускается по рецепту";
                    break;
            }
            Console.WriteLine(omit);
            Console.WriteLine("Цена: " + Price);
        }
    }
}
