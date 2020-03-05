using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Behavior
{
    public class Swim : IMoveBehavior
    {
        public void Move()
        {
            Console.WriteLine("swimming");
        }
    }
}
