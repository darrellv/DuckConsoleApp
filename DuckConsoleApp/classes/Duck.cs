using System;
using System.Collections.Generic;
using System.Text;
using DuckConsoleApp.interfaces;

namespace DuckConsoleApp.classes
{
    public abstract class Duck
    {
        private IFlyBehavior flyBehavior;
        private IQuackBehavior quackBehavior;

        protected Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            this.flyBehavior = flyBehavior;
            this.quackBehavior = quackBehavior;
            
        }

        public abstract void Display();

        public void performFly()
        {
            flyBehavior.Fly();
        }

        public void performQuack()
        {
            quackBehavior.Quack();
        }

        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
