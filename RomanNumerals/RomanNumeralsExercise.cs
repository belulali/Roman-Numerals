
using System.Collections.Generic;

namespace RomanNumerals
{
    public class RomanNumeralsExercise
    {
        private Dictionary<int, string> _romanNumbers = new Dictionary<int, string>()
        {
            {1000, "M"}, 
            {500, "D"},
            {100, "C"},
            {50, "L"},
            {10, "X"},
            {5, "V"},
            {1, "I"}
        };

     
        public string Transform(int key)
        {
            if (_romanNumbers.ContainsKey(key))
                return _romanNumbers[key];
            
            else
            {
                var finalRomanNumber = "";
                var accumulator = key;
                var firstLowerNumber = 0;

                do
                {
                    accumulator = accumulator - firstLowerNumber;
                    firstLowerNumber = GetFirstLowerNumber(accumulator);
                    var firstLowerRomanNumber = _romanNumbers[firstLowerNumber];
                    finalRomanNumber = finalRomanNumber + firstLowerRomanNumber;                   
                } while (accumulator - firstLowerNumber > 0);

                return finalRomanNumber;
            }
        }

        private int GetFirstLowerNumber(int decimalNumber)
        {
            foreach (var romanNumber in _romanNumbers)
            {
                var number = romanNumber.Key;
                if (number <= decimalNumber)
                {
                    return number;
                }
            }
            return -1;
        }
    }
}
