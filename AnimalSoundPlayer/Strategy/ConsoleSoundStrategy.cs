using AnimalSoundPlayer.Interfaces;
using System;

namespace AnimalSoundPlayer.Strategy
{
    public class ConsoleSoundStrategy : ISoundStrategy
    {
        public void PlaySound(IAnimal animal)
        {
            Console.WriteLine($"{animal.GetType().Name} makes sound: {animal.MakeSound()}");
        }
    }
}
