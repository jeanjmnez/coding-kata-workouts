using Kata.Console;

namespace Kata.Tests
{
    [TestFixture]
    public class SheepsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Count_Existing_Sheeps()
        {
            var sheeps = new bool[] { true, false, true };

            Assert.That(Console.Sheeps.CountSheeps(sheeps), Is.EqualTo(2));
        }
    }
}