using AnimalSoundPlayer.Interfaces;
using System;

namespace AnimalSoundPlayer.Models
{
    public class Chicken : IAnimal
    {
        public string MakeSound() => "Co Co Co Chhhhhaaannnneel";
    }
}
