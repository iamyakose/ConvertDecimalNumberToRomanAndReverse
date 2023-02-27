using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDemoLibrary
{
    public class RomanNumberToDecimal : IRomanNumberToDecimal
    {
        public int ConvertRomanToNumber(string romanNumberString)
        {
            int sum = 0;
            if (IsValidString(romanNumberString) == false)
                return sum;
            var romanDictionary = RomanDictionary;
            sum = GetSum(romanNumberString, sum, romanDictionary);
            return sum;
        }
        private static int GetSum(string romanNumberString, int sum, Dictionary<char, int> romanDictionary)
        {
            for (int i = 0; i < romanNumberString.Length; i++)
            {
                char currentRomanChar = romanNumberString[i];
                romanDictionary.TryGetValue(currentRomanChar, out int num);

                if (i + 1 < romanNumberString.Length && romanDictionary[romanNumberString[i + 1]] > romanDictionary[currentRomanChar])
                {
                    sum -= num;
                }
                else
                {
                    sum += num;
                }
            }

            return sum;
        }
        private static Dictionary<char, int> RomanDictionary
        {
            get
            {
                Dictionary<char, int> romanDic = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

                return romanDic;
            }
        }
        private bool IsValidString(string romanNumberString)
        {
            if (romanNumberString.Length < 3)
                return true;

            for (var i = 0; i < romanNumberString.Length - 3; ++i)
                if (romanNumberString[i] == romanNumberString[i + 1] && romanNumberString[i + 1] == romanNumberString[i + 2] && romanNumberString[i + 2] == romanNumberString[i + 3])
                    return false;
            return true;
        }
    }
}
