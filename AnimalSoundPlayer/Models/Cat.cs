using AnimalSoundPlayer.Interfaces;
using System;

namespace AnimalSoundPlayer.Models
{
    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine($"{GetType().Name} makes sound: Meow");
        }
    }
}