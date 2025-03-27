using System;

namespace AnimalSoundPlayer.Abstractions
{
    public abstract class Animal
    {
        public abstract string Type { get; }
        public abstract string Sound { get; }

        public void MakeSound()
        {
            Console.WriteLine($"{Type} makes sound: {Sound}");
        }
    }
}
