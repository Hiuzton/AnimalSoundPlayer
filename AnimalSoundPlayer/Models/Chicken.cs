using AnimalSoundPlayer.Interfaces;
using System;

namespace AnimalSoundPlayer.Models
{
    public class Chicken : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine($"{GetType().Name} makes sound: Co Co Co Chhhhhaaannnneel");
        }
    }
}
