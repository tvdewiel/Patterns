using Strategy.Behavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Animals
{
    public class Shark : Animal
    {
        public Shark(string name, IMoveBehavior moveBehavior, IEatBehaviour eatBehavior) : base(name, moveBehavior, eatBehavior)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"Me shark {name}");
        }
    }
}
