using System;
using System.Collections.Generic;
using System.Text;

namespace DuckConsoleApp.classes
{
    class MuteQuack : DuckConsoleApp.interfaces.IQuackBehavior 
    {
        public void Quack()
        {
            Console.WriteLine("<< SILENCE >>");
        }
    }
}
