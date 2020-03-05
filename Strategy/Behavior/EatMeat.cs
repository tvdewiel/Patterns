using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Behavior
{
    public class EatMeat : IEatBehaviour
    {
        public void Eat()
        {
           Console.WriteLine("eating meat");
        }
    }
}
