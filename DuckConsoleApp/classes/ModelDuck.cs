using System;
using System.Collections.Generic;
using System.Text;

namespace DuckConsoleApp.classes
{
    public class ModelDuck : Duck
    {
        public ModelDuck() : base(new FlyNoWay(), new RegularQuack())
        {

        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
