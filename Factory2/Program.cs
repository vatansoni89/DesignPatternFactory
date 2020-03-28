using Factory2.Autos;
using System;

namespace Factory2
{
    /// <summary>
    /// simple factory
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            
            string carName = Console.ReadLine()??args[0];

            AutoFactory factory = new AutoFactory();

            IAuto car = factory.CreateInstance(carName);

            car.TurnOn();
            car.TurnOff();
        }
    }
}
