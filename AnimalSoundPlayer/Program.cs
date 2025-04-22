using AnimalSoundPlayer.Factory;
using AnimalSoundPlayer.Interfaces;
using AnimalSoundPlayer.Models;
using AnimalSoundPlayer.Strategy;
using System;
using System.Collections.Generic;

namespace AnimalSoundPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>
            {
                AnimalFactory.Create("cat"),
                AnimalFactory.Create("chicken"),
                AnimalFactory.Create("dog"),
                AnimalFactory.Create("pig"),
            };

            ISoundStrategy strategy = new ConsoleSoundStrategy();

            foreach (var animal in animals)
            {
                strategy.PlaySound(animal);
            }

            Console.ReadLine();
        }
    }
}
