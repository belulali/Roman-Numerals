
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
            var expected = romanNumerals.Transform(1);
            Assert.That("I", Is.EqualTo(expected));
        }

        [Test]
        public void ShouldReturnIIWhenGivenTwo()
        {
            var romanNumerals = new RomanNumeralsExercise();
            var expected = romanNumerals.Transform(2);
            Assert.That("II", Is.EqualTo(expected));
        }
    }
}
