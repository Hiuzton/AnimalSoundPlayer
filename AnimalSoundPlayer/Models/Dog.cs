using AnimalSoundPlayer.Interfaces;
using System;

namespace AnimalSoundPlayer.Models
{
    public class Dog : IAnimal
    {
        public string MakeSound() => "Gaf Gaf";
    }
}
