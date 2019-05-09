using System;

namespace Birds
{
    public class YesFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Yes, I'm flying");
        }
    }
}