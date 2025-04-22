using AnimalSoundPlayer.Interfaces;
using System;

namespace AnimalSoundPlayer.Models
{
    public class Cat : IAnimal
    {
        public string MakeSound() => "Meow";
    }
}