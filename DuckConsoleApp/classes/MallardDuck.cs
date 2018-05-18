using System;
using System.Collections.Generic;
using System.Text;

namespace DuckConsoleApp.classes
{
    class MallardDuck : Duck 
    {
        public MallardDuck() : base(new FlyWithWings(), new RegularQuack())
        {
            //RegularQuack quackBehavior = new RegularQuack();

            //FlyWithWings flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
