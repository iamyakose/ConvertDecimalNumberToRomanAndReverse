using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDemoLibrary
{
    public class DecimalNumberToRoman : IDecimalNumberToRoman
    {
        public string ConvertDecimalToRoman(string numberString)
        {
            string romanValue = string.Empty;
            int number = Convert.ToInt32(numberString);
            if (number >= 1)
            {
                foreach (int item in RomanDictionary().Keys)
                {
                    while (number >= item)
                    {
                        romanValue = romanValue + RomanString(item);
                        number -= item;
                    }
                }
            }
            return romanValue;
        }
        private static string RomanString(int n)
        {
            string romanString = string.Empty;
            romanString = RomanDictionary()[n].ToString();
            return romanString;
        }
        private static Dictionary<int, string> RomanDictionary()
        {
            Dictionary<int, string> romanDictionary = new Dictionary<int, string>()
            {
                {1000,"M"},
                {900, "CM" },
                {500, "D"},
                {400, "CD" },
                {100, "C" },
                {90, "XC" },
                {50, "L" },
                {40, "XL" },
                {10, "X" },
                {9, "IX" },
                {5, "V" },
                {4, "IV" },
                {1, "I" }
            };

            return romanDictionary;
        }
        private static bool IsValid(string input)
        {
            int value = 0;
            bool isValid = false;
            if (int.TryParse(input, out value))
            {
                if (value <= 3999)
                {
                    isValid = true;
                }
            }
            return isValid;
        }
    }
}
