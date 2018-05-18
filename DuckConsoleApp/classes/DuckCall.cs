using System;
using System.Collections.Generic;
using System.Text;
using DuckConsoleApp.interfaces;

namespace DuckConsoleApp.classes
{
    class DuckCall : IQuackBehavior 
    {
        private IQuackBehavior quackBehavior;

        public DuckCall(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }

        public void Quack()
        {
            quackBehavior.Quack();
        }
    }
}
