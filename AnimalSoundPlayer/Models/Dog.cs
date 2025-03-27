using AnimalSoundPlayer.Abstractions;

namespace AnimalSoundPlayer.Models
{
    public class Dog : Animal
    {
        public override string Type => "Dog";
        public override string Sound => "Gaf Gaf";
    }
}
