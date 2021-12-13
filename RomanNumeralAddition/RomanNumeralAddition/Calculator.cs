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

        public int convertRomanToNumbers(string numeral)
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

        public int calculateNumbersToNumbers(int[] placements)
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
