using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird christianBird = new RubberDuck();
            christianBird.Display();
            christianBird.SetFlyBehavior(new YesFly());
            christianBird.PerformFly();
            christianBird.PerformQuack();
            christianBird.Swim();
            
            Bird mortyBird = new Swallow();
            mortyBird.Display();
            mortyBird.PerformFly();
            mortyBird.PerformQuack();
            mortyBird.Swim();

        }
    }
}
