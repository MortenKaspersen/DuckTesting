using System;

namespace Birds
{
    public class Swallow : Bird
    {
        public Swallow()
        {
            flyBehavior = new YesFly();
            quackBehavior = new YesQuack();
        }

        public override void Swim()
        {
            Console.WriteLine("Dude, I can't swim !!!!");
        }

        public override void Display()
        {
            Console.WriteLine("Yes, I'm a Swallow !");
        }

    }
}