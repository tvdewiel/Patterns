using Strategy.Animals;
using Strategy.Behavior;
using System;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IMoveBehavior running = new Run();
            IMoveBehavior flying = new Fly();
            IMoveBehavior swiming = new Swim();
            IEatBehaviour meat = new EatMeat();
            IEatBehaviour veggie = new EatVegie();
            IEatBehaviour fish = new EatFish();

            Lion l1 = new Lion("Leo",running,meat);
            Shark s1 = new Shark("Nemo", swiming, fish);
            Tiger t1 = new Tiger("Marcel", running, meat);
            Flamingo f1 = new Flamingo("Jenny", flying, fish);
            Elephant e1 = new Elephant("Bobby", running, veggie);

            Zoo zoo = new Zoo();
            zoo.AddAnimal(l1);
            zoo.AddAnimal(s1);
            zoo.AddAnimal(t1);
            zoo.AddAnimal(f1);
            zoo.AddAnimal(e1);
            Console.WriteLine("------Feeding time");
            zoo.Feed();
            Console.WriteLine("------And action");
            zoo.Action();

        }
    }
}
