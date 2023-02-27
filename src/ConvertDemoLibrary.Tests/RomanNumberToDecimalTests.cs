using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDemoLibrary.Tests
{
    public class RomanNumberToDecimalTests : IDisposable
    {
        private readonly IRomanNumberToDecimal _romanNumberToDecimal;
        public RomanNumberToDecimalTests()
        {
            _romanNumberToDecimal = Factory.CreateRomanNumberToDecimal();
        }
        
        [Theory]
        [InlineData("IIII", 0)]
        [InlineData("III", 3)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        [InlineData("MCMXCIX", 1999)]
        [InlineData("MMCDXLIV", 2444)]
        [InlineData("XC", 90)]
        public void ConvertRomanToNumber_Should_ConvertRomanNumeralToNumberTheory(string input, int expected)
        {
            // Arrange          

            // Act            
            int actual = _romanNumberToDecimal.ConvertRomanToNumber(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        public void Dispose()
        {
            // Notify the garbage collector
            // about the cleaning event
            GC.SuppressFinalize(this);
        }
    }
}
