using Strategy.Behavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Animals
{
    public abstract class Animal
    {
        IMoveBehavior moveBehavior;
        IEatBehaviour eatBehavior;
        public string name { get; set; }

        protected Animal(string name, IMoveBehavior moveBehavior, IEatBehaviour eatBehavior):this(name)
        {
            this.moveBehavior = moveBehavior;
            this.eatBehavior = eatBehavior;
        }

        protected Animal(string name)
        {
            this.name = name;
        }

        public abstract void Display();
        public void Move()
        {
            moveBehavior.Move();
        }
        public void Eat()
        {
            eatBehavior.Eat();
        }
        public void SetMoveBehaviour(IMoveBehavior moving)
        {
            moveBehavior = moving;
        }
        public void SetEatBehaviour(IEatBehaviour eating)
        {
            eatBehavior = eating;
        }
    }
}
