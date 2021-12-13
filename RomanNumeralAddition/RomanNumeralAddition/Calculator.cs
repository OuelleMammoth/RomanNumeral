using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralAddition
{
    class Calculator
    {
        public Calculator()
        {
        }

        public int createNumberValue(string numeral)
        {
            int length = numeral.Length;
            int value = 0;

            string[] numeralPlacements = new string[length];
            int[] numberPlacements = new int[length];

            for (int i = 0; i < length; i++)
            {
                numeralPlacements[i] = numeral.Substring(i, 1);
            }
            for (int i = 0; i < length; i++)
            {
                numberPlacements[i] = convertRomanToNumbers(numeralPlacements[i]);
            }

            value = calculateNumbersToNumbers(numberPlacements);
            return value;

        }

        public string createNumeralValue(int number)
        {
            string numeralValue = "";
            int numberValue = number;
            while(numberValue > 0)
            {
                if(numberValue > 1000)
                {
                    numeralValue += "M";
                    numberValue -= 1000;
                }
                else if(numberValue > 900)
                {
                    numeralValue += "CM";
                    numberValue -= 900;
                }
                else if (numberValue > 500)
                {
                    numeralValue += "D";
                    numberValue -= 500;
                }
                else if (numberValue > 400)
                {
                    numeralValue += "CD";
                    numberValue -= 400;
                }
                else if (numberValue > 100)
                {
                    numeralValue += "C";
                    numberValue -= 100;
                }
                else if (numberValue > 90)
                {
                    numeralValue += "XC";
                    numberValue -= 90;
                }
                else if (numberValue > 50)
                {
                    numeralValue += "L";
                    numberValue -= 50;
                }
                else if (numberValue > 40)
                {
                    numeralValue += "XL";
                    numberValue -= 40;
                }
                else if (numberValue > 10)
                {
                    numeralValue += "X";
                    numberValue -= 10;
                }
                else if (numberValue > 9)
                {
                    numeralValue += "IX";
                    numberValue -= 9;
                }
                else if (numberValue > 5)
                {
                    numeralValue += "V";
                    numberValue -= 5;
                }
                else if (numberValue > 4)
                {
                    numeralValue += "IV";
                    numberValue -= 900;
                }
                else if (numberValue > 1)
                {
                    numeralValue += "I";
                    numberValue -= 1;
                }
            }
            return numeralValue;
        }

        private int convertRomanToNumbers(string numeral)
        {
            if (numeral == "I")
            {
                return 1;
            }
            else if (numeral == "V")
            {
                return 5;
            }
            else if (numeral == "X")
            {
                return 10;
            }
            else if (numeral == "L")
            {
                return 50;
            }
            else if (numeral == "C")
            {
                return 100;
            }
            else if (numeral == "D")
            {
                return 500;
            }
            else if (numeral == "M")
            {
                return 1000;
            }
            else
            {
                return 0;
            }
        }

        private int calculateNumbersToNumbers(int[] placements)
        {
            int length = placements.Length;
            int value = 0;
            for(int i = 0; i < length; i++)
            {
                if(placements[i] == 0)
                {
                }
                else if(placements[i] < placements[i + 1])
                {
                    placements[i] = placements[i + 1] - placements[i];
                    placements[i + 1] = 0;
                }
            }
            
            foreach(int placement in placements)
            {
                value = value + placement;
            }
            return value;
        }

    }
}
