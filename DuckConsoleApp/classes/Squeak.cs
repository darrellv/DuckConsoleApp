using System;
using System.Collections.Generic;
using System.Text;

namespace DuckConsoleApp.classes
{
    class Squeak : DuckConsoleApp.interfaces.IQuackBehavior 
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
