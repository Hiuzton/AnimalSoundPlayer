using AnimalSoundPlayer.Interfaces;
using System;

namespace AnimalSoundPlayer.Models
{
    public class Pig : IAnimal
    {
        public string MakeSound() => "Hriu Hriu";
    }
}
