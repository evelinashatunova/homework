using ClassLibrary1;
using System;

namespace ClassLibrary1
{
    public enum PersonGender
    {
        Male,
        Female
    }
}

public class Person
    {
        public string Name;
        public string Surname;
        public readonly DateTime Birthday;
        public readonly PersonGender gender;

        
        public int Age
        {
            get
            {
                return DateTime.Now.Year - Birthday.Year;
            }
        }

        public Person(string Name, string Surname, string Birthday,  PersonGender gender)
        {
            Name = Name;
            Surname = Surname;
            gender = gender;
            _ = DateTime.Parse(Birthday);

        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
        public void PrintInfo()
        {
            Console.WriteLine(this);
            var gender = "";
            switch(gender)
            {
                case PersonGender.Male:
                    gender = "мужской";
                        break;
                case PersonGender.Female:
                    gender = "женский";
                    break;
            }
            Console.WriteLine($"Дата рождения: {Birthday:d}. Поло:{gender}. Возраст:{Age}.");
        }
    }

