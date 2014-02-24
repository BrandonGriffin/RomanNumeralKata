using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralKata
{
    public class Converter
    {
        
        public Int32 Convert(String numeral)
        {
            var number = 0;
            var conversionChart = new Dictionary<Char, Int32>
                                    {
                                        { 'I', 1 },
                                        { 'V', 5 }
                                    };
            

            foreach (var letter in numeral)
                    number += conversionChart[letter];

            return number;
        }
    }
}
