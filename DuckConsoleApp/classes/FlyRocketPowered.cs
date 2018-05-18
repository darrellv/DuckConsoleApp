using System;
using System.Collections.Generic;
using System.Text;

namespace DuckConsoleApp.classes
{
    public class FlyRocketPowered : DuckConsoleApp.interfaces.IFlyBehavior 
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
