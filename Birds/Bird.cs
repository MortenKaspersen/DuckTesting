using System;

namespace Birds
{
    public abstract class Bird
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public Bird()
        {

        }

        public virtual void Swim()
        {
            Console.WriteLine("Dooh, All duck can swim !!!!\n");
        }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
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