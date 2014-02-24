using System;
using System.Collections.Generic;

namespace RomanNumeralKata
{
    public class Converter
    {
        public Int32 Convert(String numeral)
        {
            var conversionChart = new Dictionary<Char, Int32>
                                    {
                                        { 'I', 1 },
                                        { 'V', 5 },
                                        { 'X', 10 },
                                        { 'L', 50 },
                                        { 'C', 100 },
                                        { 'D', 500 },
                                        { 'M', 1000 }
                                    };

            var number = 0;
            
            for (var i = 0; i < numeral.Length; i++)
            {
                var numberToAdd = conversionChart[numeral[i]];
                number += numberToAdd;

                if (i > 0 && NumberShouldBeSubtracted(conversionChart[numeral[i - 1]], numberToAdd))
                    number -= 2 * conversionChart[numeral[i - 1]]; 
            }

            return number;
        }

        private Boolean NumberShouldBeSubtracted(Int32 previousNumber, Int32 numberToAdd)
        {
            return numberToAdd > previousNumber;
        }
    }
}