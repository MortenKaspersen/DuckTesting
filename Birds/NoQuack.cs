using System;

namespace Birds
{
    public class NoQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I'm not saying anything");
        }
    }
}