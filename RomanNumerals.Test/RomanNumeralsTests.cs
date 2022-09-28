using FluentAssertions;
using RomanNumerals.Models;

namespace RomanNumerals.Test
{
    public class RomanNumeralsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Roman_numeral_conversion_into_number_basic()
        {
            RomanNumeralConvertor.ConvertRomanNumeral("I").Should().Be(1);
            RomanNumeralConvertor.ConvertRomanNumeral("V").Should().Be(5);
            RomanNumeralConvertor.ConvertRomanNumeral("X").Should().Be(10);
            RomanNumeralConvertor.ConvertRomanNumeral("L").Should().Be(50);
            RomanNumeralConvertor.ConvertRomanNumeral("C").Should().Be(100);
            RomanNumeralConvertor.ConvertRomanNumeral("D").Should().Be(500);
            RomanNumeralConvertor.ConvertRomanNumeral("M").Should().Be(1000);
        }
        [Test]
        public void Roman_numeral_conversion_into_number_increament()
        {
            RomanNumeralConvertor.ConvertRomanNumeral("II").Should().Be(2);
            RomanNumeralConvertor.ConvertRomanNumeral("III").Should().Be(3);
            RomanNumeralConvertor.ConvertRomanNumeral("VI").Should().Be(6);
            RomanNumeralConvertor.ConvertRomanNumeral("VII").Should().Be(7);
            RomanNumeralConvertor.ConvertRomanNumeral("VIII").Should().Be(8);
            RomanNumeralConvertor.ConvertRomanNumeral("XXVII").Should().Be(27);
        }

        [Test]
        public void Roman_numeral_conversion_into_number_Decrement()
        {
            RomanNumeralConvertor.ConvertRomanNumeral("IV").Should().Be(4);
            RomanNumeralConvertor.ConvertRomanNumeral("IX").Should().Be(9);
        }

        [Test]
        public void Roman_numeral_conversion_into_number_three_digits()
        {
            RomanNumeralConvertor.ConvertRomanNumeral("CDXCIX").Should().Be(499);
            RomanNumeralConvertor.ConvertRomanNumeral("DCLXXXVIII").Should().Be(688);
        }

        [Test]
        public void Roman_numeral_conversion_into_number_four_digits()
        {
            RomanNumeralConvertor.ConvertRomanNumeral("MCMXCIV").Should().Be(1994);
            RomanNumeralConvertor.ConvertRomanNumeral("MMXXII").Should().Be(2022);
        }

    }
}