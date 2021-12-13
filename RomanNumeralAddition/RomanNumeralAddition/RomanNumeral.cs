using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralAddition
{
    class RomanNumeral
    {
        Calculator Calculator = new Calculator();
        string numeral = "";
        int value = 0;

        public RomanNumeral(string numeral)
        {
            this.numeral = numeral;

            value = Calculator.createNumberValue(numeral);
        }

        
    }
}
