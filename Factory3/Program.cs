using System.Reflection;
using Factory3.Autos;
using Factory3.Factories;

namespace Factory3
{
    class Program
    {
        static void Main()
        {
            //Adds an interface to the factory itself from Simple Factory.
            //Defers object creation to multiple factories that share an interface.
            //Derived classes IMPLEMENTS or override the factory method of the base.

            //Here we are loading specific factory on the fly from app settings then create specific object like BMW or MiniCooper
            IAutoFactory autoFactory = LoadFactory(); //BMWFactory

            IAuto car = autoFactory.CreateAutomobile();
            
            car.TurnOn();
            car.TurnOff();
        }

        static IAutoFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.AutoFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }
    }

}