using System;
using DuckConsoleApp.classes;

namespace DuckConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();

            mallard.Display();
            mallard.performQuack();
            mallard.performFly();


            Duck model = new ModelDuck();
            model.Display();
            model.performFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.performFly();

            Console.WriteLine("The following is a duck call");
            DuckCall duckCall = new DuckCall(new RegularQuack());
            duckCall.Quack();

            Console.ReadLine();
        }
    }
}
