using AnimalSoundPlayer.Abstractions;

namespace AnimalSoundPlayer.Models
{
    public class Cat : Animal
    {
        public override string Type => "Cat";

        public override string Sound => "Miau Miau Miau";
    }
}
