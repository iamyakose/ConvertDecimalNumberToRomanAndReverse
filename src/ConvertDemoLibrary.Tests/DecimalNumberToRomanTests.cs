using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDemoLibrary.Tests
{
    public class DecimalNumberToRomanTests : IDisposable
    {
        private readonly IDecimalNumberToRoman _decimalNumberToRoman;
        public DecimalNumberToRomanTests()
        {
            _decimalNumberToRoman = Factory.CreateDecimalNumberToRoman();
        }

        [Theory]
        [InlineData("3", "III")]
        [InlineData("1994", "MCMXCIV")]
        [InlineData("1999", "MCMXCIX")]
        [InlineData("2444", "MMCDXLIV")]
        [InlineData("90", "XC")]
        public void ConvertDecimalToRoman_Should_ConvertDecimalNumberTheory(string input, string expected)
        {
            // Arrange          

            // Act            
            string actual = _decimalNumberToRoman.ConvertDecimalToRoman(input);

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
