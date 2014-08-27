
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
        
        [Ignore]
        [Test]
        public void ShouldReturnIVWhenGivenFour()
        {
            var romanNumerals = new RomanNumeralsExercise();
            var actual = romanNumerals.Transform(4);
            Assert.That(actual, Is.EqualTo("IV"));
        }

        [Test]
        public void ShouldReturnVWhenGivenFive()
        {
            var romanNumerals = new RomanNumeralsExercise();
            var actual = romanNumerals.Transform(5);
            Assert.That(actual, Is.EqualTo("V"));
        }


    }
}
