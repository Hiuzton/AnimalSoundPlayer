using AnimalSoundPlayer.Interfaces;
using System;

namespace AnimalSoundPlayer.Models
{
    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine($"{GetType().Name} makes sound: Gaf Gaf");
        }
    }
}
