using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Behavior
{
    public class EatFish : IEatBehaviour
    {
        public void Eat()
        {
            Console.WriteLine("eating fish");
        }
    }
}
