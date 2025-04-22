using AnimalSoundPlayer.Factory;
using AnimalSoundPlayer.Models;

namespace AnimalSoundPlayer.Tests
{
    [TestClass]
    public class AnimalFactoryTests
    {
        [TestMethod]
        public void Should_Create_Dog_Instance()
        {
            var animal = AnimalFactory.Create("dog");
            Assert.IsInstanceOfType(animal, typeof(Dog));
        }
    }
}
