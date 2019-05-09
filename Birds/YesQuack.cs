using System;

namespace Birds
{
    public class YesQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Bird sound playing !");
        }
    }
}