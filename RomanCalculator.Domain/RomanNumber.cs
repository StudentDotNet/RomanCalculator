using System;
using System.Collections.Generic;
using System.Text;

namespace RomanCalculator.Domain
{
    public class RomanNumber
    {
       private readonly Dictionary<char, int> _mapRoman = new Dictionary<char, int>()
       {
           {'I', 1},
           {'V', 5},
           {'X', 10},
           {'L', 50},
           {'C', 100},
           {'D', 500},
           {'M', 1000},
           {'(', 0},
           {')', 0},
       };

        private int? _cachedIntValue { get; set; } = null;

        public string Value { get; }

        public RomanNumber(string value) 
        {
            Value = value;
        }

        public RomanNumber(int value)
        {
            _cachedIntValue = value;
            Value = ConvertIntToRoman(value);
        }

        public int ToNumber()
        {
            if (_cachedIntValue != null) return _cachedIntValue.Value;

            var number = 0;
            var length = Value.Length;
            for (var i = 0; i < length; i++)
            {
                var temp = Value[i];
                int num1;
                int num2;

                var k = i + 1 > length ? i + 1 : i;

                _mapRoman.TryGetValue(Value[i], out num1);
                _mapRoman.TryGetValue(Value[k], out num2);

                if (num1 > 0 && num1 < num2)
                {
                    number -= num1;
                }
                else
                {
                    number += num1;
                }
            }

            return number;
        }

        private string ConvertIntToRoman(int value)
        {
            
            var roman = new[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            var numbers = new [] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            var builder = new StringBuilder();
            if (value < 0)
            {
                value = Math.Abs(value);
                builder.Append("-");
            }

            for (int i = 0; i < 13; i++)
            {
                while (value >= numbers[i])
                {
                    value -= numbers[i];
                    builder.Append(roman[i]);
                }
            }

            return builder.ToString();
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
