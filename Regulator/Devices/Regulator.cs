using System;
using System.Timers;

namespace Devices

{
    //Данный код нарушает принцип DIP,
    //потому что класс Regulator зависит от конкретных классов Oven и CofeeMaker,
    //которые являются низкоуровневыми модулеми.
    //Если Oven и\или CofeeMaker изменятся или будут заменены другими классами,
    //то Regulator тоже придется менять.

    public interface IHeatable 
    { 
        int Temperature { get; set; } 
        bool IsEngaged { get; set; } 
        void Engage(); 
        void Disengage();
    }
    public class Regulator
    {
        IHeatable device;
        Oven oven;
        CofeeMaker cofeeMaker;
        Timer timer;
        int minT, maxT, timeRemained;
        public Regulator(IHeatable oven) //в конструкторе принимаем любой объект, реализующий IHeatable
        {
            this.device = oven;
            timer = new Timer(500);
            timer.Stop();
            timer.Elapsed += Control;
        }
        //public Regulator(Oven oven)
        //{
        //    this.oven = oven;
        //    timer = new Timer(500);
        //    timer.Stop();
        //    timer.Elapsed += Control;
        //}
        //public Regulator(CofeeMaker cofeeMaker)
        //{
        //    this.cofeeMaker = cofeeMaker;
        //    timer = new Timer(500);
        //    timer.Stop();
        //    timer.Elapsed += CofeeControl;
        //}

        public void Regulate(int minTemperature, int maxTemperature, int timeInSeconds)
        {
            minT = minTemperature;
            maxT = maxTemperature;
            timeRemained = timeInSeconds;
            timer.Start();
        }

        void Control(object obj, ElapsedEventArgs e)
        {
            if (device.Temperature <= minT && !device.IsEngaged)
                device.Engage();
            else if(device.Temperature >= maxT && device.IsEngaged)
                device.Disengage();
            timeRemained = (int)((timeRemained * 1000 - timer.Interval) / 1000);
            if(timeRemained <= 0)
            {
                timer.Stop();
                device.Disengage();
                Console.WriteLine("Регулятор: время истекло");
            }
        }
        void CofeeControl(object obj, ElapsedEventArgs e)
        {
            if (cofeeMaker.Temperature <= minT && !cofeeMaker.IsWorking)
                cofeeMaker.IsWorking = true;
            else if (cofeeMaker.Temperature >= maxT && cofeeMaker.IsWorking)
                cofeeMaker.IsWorking = false;
            timeRemained = (int)((timeRemained * 1000 - timer.Interval) / 1000);
            if (timeRemained <= 0)
            {
                timer.Stop();
                cofeeMaker.IsWorking = false;
                Console.WriteLine("Регулятор: время истекло");
            }
        }

    }
}
