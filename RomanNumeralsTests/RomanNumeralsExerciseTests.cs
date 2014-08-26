
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
    }
}
