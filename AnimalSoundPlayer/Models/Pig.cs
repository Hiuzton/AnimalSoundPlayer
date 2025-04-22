using AnimalSoundPlayer.Interfaces;
using System;

namespace AnimalSoundPlayer.Models
{
    public class Pig : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine($"{GetType().Name} makes sound: Hriu Hriu");
        }
    }
}
