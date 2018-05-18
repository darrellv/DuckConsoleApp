using System;
using System.Collections.Generic;
using System.Text;

namespace DuckConsoleApp.classes
{
    class FlyNoWay : DuckConsoleApp.interfaces.IFlyBehavior 
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }
}
