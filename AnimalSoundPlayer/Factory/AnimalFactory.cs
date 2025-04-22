using AnimalSoundPlayer.Interfaces;
using AnimalSoundPlayer.Models;
using System;

namespace AnimalSoundPlayer.Factory
{
    public static class AnimalFactory
    {
        public static IAnimal Create(string type)
        {
            switch(type.ToLower())
            {
                case "cat":
                    return new Cat();
                case "chicken":
                    return new Chicken();
                case "dog":
                    return new Dog();
                case "pig":
                    return new Pig();
                default:
                    throw new ArgumentException("Unknown animal type.");
            };
        }
    }
}
