using System;
using System.Reflection;
using Factory4.Factory;

namespace Factory4
{
    /// <summary>
    /// Abstract Factory: Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
    /// 1. Factories create different types of concrete objects (products).
    /// 2. A factory now represents a "family" of objects that it can create.
    /// 3. Factories may have more than one factory method.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IAutoFactory factory = LoadFactory();

            PrintHeader("SPORTS CAR");
            var car = factory.CreateSportsCar();
            car.TurnOn();
            car.TurnOff();

            PrintHeader("LUXURY CAR");
            car = factory.CreateLuxuryCar();
            car.TurnOn();
            car.TurnOff();

            PrintHeader("ECONOMY CAR");
            car = factory.CreateEconomyCar();
            car.TurnOn();
            car.TurnOff();

        }

        static IAutoFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.AutoFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }

        static void PrintHeader(string title)
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++ {0} ++++++++++++++++++", title);
        }
    }
}
