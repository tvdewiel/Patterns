using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Behavior
{
    public class Run : IMoveBehavior
    {
        public void Move()
        {
            Console.WriteLine("running");
        }
    }
}
