using AnimalSoundPlayer.Models;
using AnimalSoundPlayer.Strategy;

namespace AnimalSoundPlayer.Tests
{
    [TestClass]
    public class ConsoleStrategyTests
    {
        [TestMethod]
        public void Should_Output_Sound_To_Console()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var dog = new Dog();
            var strategy = new ConsoleSoundStrategy();
            strategy.PlaySound(dog);

            string result = output.ToString();
            Assert.IsTrue(result.Contains("Dog makes sound: Gaf Gaf"));
        }
    }
}
