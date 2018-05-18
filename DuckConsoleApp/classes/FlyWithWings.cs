using System;
using System.Collections.Generic;
using System.Text;

namespace DuckConsoleApp.classes
{
    class FlyWithWings : DuckConsoleApp.interfaces.IFlyBehavior 
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
