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

            foreach (var letter in numeral)
                if (letter == 'I')
                    number++;

            return number;
        }
    }
}
