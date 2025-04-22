using AnimalSoundPlayer.Interfaces;
using AnimalSoundPlayer.Models;
using System.Collections.Generic;

namespace AnimalSoundPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>()
            {
                new Cat(),
                new Chicken(),
                new Dog(),
                new Pig()
            };

            foreach (var animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}
