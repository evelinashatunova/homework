using System;
using Devices;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var thermometer = new Thermometer(22);
            Oven oven = new Oven(thermometer, 20);

            Regulator regulator = new Regulator(oven as IHeatable);
            regulator.Regulate(180, 200, 120);

            var cofeeMaker = new CofeeMaker(thermometer);
            cofeeMaker.SwitchOn();
            
            Console.ReadKey();
        }
    }
}
