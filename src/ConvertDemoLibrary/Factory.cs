using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDemoLibrary
{
    public static class Factory
    {
        public static IRomanNumberToDecimal CreateRomanNumberToDecimal() { return new RomanNumberToDecimal(); }
        public static IDecimalNumberToRoman CreateDecimalNumberToRoman() { return new DecimalNumberToRoman(); }
    }
}
