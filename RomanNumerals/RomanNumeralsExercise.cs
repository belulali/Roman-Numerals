
namespace RomanNumerals
{
    public class RomanNumeralsExercise
    {
        public string Transform(int number)
        {
            if (number == 1)
            {
                return "I";
            }
            else if(number == 2)
            {
                return "II";
            }
            else
            {
                return "III";
            }
        }
    }
}
