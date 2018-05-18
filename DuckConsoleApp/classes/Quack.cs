using System;
using System.Collections.Generic;
using System.Text;

namespace DuckConsoleApp.classes
{
    class RegularQuack : DuckConsoleApp.interfaces.IQuackBehavior  
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
