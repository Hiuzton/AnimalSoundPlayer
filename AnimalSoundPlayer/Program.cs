using AnimalSoundPlayer.Abstractions;
using AnimalSoundPlayer.Models;
using System.Collections.Generic;

namespace AnimalSoundPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>()
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
