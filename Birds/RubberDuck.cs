using System;

namespace Birds
{
    public class RubberDuck : Bird
    {
        public RubberDuck()
        {
            flyBehavior = new NoFly();
            quackBehavior = new NoQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Oh, I'm a RubberDuck !");
        }

    }
}