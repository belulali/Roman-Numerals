
using NUnit.Framework;
using RomanNumerals;

namespace RomanNumeralsTests
{
    public class RomanNumeralsExerciseTests
    {
        [Test]
        public void ShouldReturnIWhenGivenOne()
        {
            var romanNumerals = new RomanNumeralsExercise();
            var actual = romanNumerals.Transform(1);
            Assert.That(actual, Is.EqualTo("I"));
        }

        [Test]
        public void ShouldReturnIIWhenGivenTwo()
        {
            var romanNumerals = new RomanNumeralsExercise();
            var actual = romanNumerals.Transform(2);
            Assert.That(actual, Is.EqualTo("II"));
        }

        [Test]
        public void ShouldReturnIIIWhenGivenThree()
        {
            var romanNumerals = new RomanNumeralsExercise();
            var actual = romanNumerals.Transform(3);
            Assert.That(actual, Is.EqualTo("III"));
        }
    }
}
