﻿using System;
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
                                        { 'V', 5 },
                                        { 'X', 10 },
                                        { 'L', 50 },
                                        { 'C', 100 },
                                        { 'D', 500 },
                                        { 'M', 1000 }
                                    };
            

            foreach (var letter in numeral)
                    number += conversionChart[letter];

            return number;
        }
    }
}
