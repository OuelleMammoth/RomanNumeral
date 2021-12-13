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
        private string numeral = "";
        private int numberValue = 0;

        public RomanNumeral()
        {
        }
        public RomanNumeral(string numeralString)
        {
            numeral = numeralString;

            numberValue = Calculator.createNumberValue(numeral);
        }

        public string Numeral
        {
            get { return numeral; }
            set 
            { 
                numeral = value;
                numberValue = Calculator.createNumberValue(value);
            }
        }

        public int NumberValue
        {
            get { return numberValue; }
            set
            {
                numberValue = value;
                numeral = Calculator.createNumeralValue(value);
            }
        }

        
    }
}
