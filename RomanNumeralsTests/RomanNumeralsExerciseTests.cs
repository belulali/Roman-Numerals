
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

        [Test]
        public void ShouldReturnVIWhenGivenSix()
        {
            var romanNumerals = new RomanNumeralsExercise();
            var actual = romanNumerals.Transform(6);
            Assert.That(actual, Is.EqualTo("VI"));
        }

        [Test]
        public void ShouldReturnXWhenGivenTen()
        {
            var romanNumerals = new RomanNumeralsExercise();
            var actual = romanNumerals.Transform(10);
            Assert.That(actual, Is.EqualTo("X"));
        }

        [Test]
        public void ShouldReturnLWhenGivenFifty()
        {
            var romanNumerals = new RomanNumeralsExercise();
            var actual = romanNumerals.Transform(50);
            Assert.That(actual, Is.EqualTo("L"));
        }

        [Test]
        public void ShouldReturnCWhenGivenOneHundred()
        {
            var romanNumerals = new RomanNumeralsExercise();
            var actual = romanNumerals.Transform(100);
            Assert.That(actual, Is.EqualTo("C"));
        }

        [Test]
        public void ShouldReturnDWhenGivenFiveHundred()
        {
            var romanNumerals = new RomanNumeralsExercise();
            var actual = romanNumerals.Transform(500);
            Assert.That(actual, Is.EqualTo("D"));
        }

        [Test]
        public void ShouldReturnMWhenGivenOneThousand()
        {
            var romanNumerals = new RomanNumeralsExercise();
            var actual = romanNumerals.Transform(1000);
            Assert.That(actual, Is.EqualTo("M"));
        }





    }
}
