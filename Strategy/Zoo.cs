using Strategy.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Zoo
    {
        List<Animal> animals;

        public Zoo()
        {
            animals = new List<Animal>();
        }
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
        public void Feed()
        {
            foreach(Animal a in animals)
            {
                a.Display();
                a.Eat();
            }
        }
        public void Action()
        {
            foreach (Animal a in animals)
            {
                a.Display();
                a.Move();
            }
        }
    }
}
