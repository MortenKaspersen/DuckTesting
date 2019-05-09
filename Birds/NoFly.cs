using System;

namespace Birds
{
    public class NoFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("No, I'm not going anywhere");
        }
    }
}