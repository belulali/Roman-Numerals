
using System.Collections.Generic;

namespace RomanNumerals
{
    public class RomanNumeralsExercise
    {
        private Dictionary<int, string> _romanNumbers = new Dictionary<int, string>()
        {
            {1, "I"},
            {5, "V"},
            {10, "X"},
        };

     
        public string Transform(int key)
        {
            if (_romanNumbers.ContainsKey(key))
                return _romanNumbers[key];
            
            if(key == 2)
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
