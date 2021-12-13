using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralAddition
{
    class Launch
    {
        static void Main()
        {
            string numeralOne;
            string numeralTwo;
            RomanNumeral output = new RomanNumeral();

            Console.WriteLine("The Program will add two roman numerals together");
            Console.WriteLine("Please enter the first numeral");
            numeralOne = Console.ReadLine();
            Console.WriteLine("Please enter the second numeral");
            numeralTwo = Console.ReadLine();

            Console.WriteLine();

            RomanNumeral one = new RomanNumeral(numeralOne);
            RomanNumeral two = new RomanNumeral(numeralTwo);

            output.NumberValue = one.NumberValue + two.NumberValue;

            Console.WriteLine("The total number value is:");
            Console.WriteLine(output.NumberValue);
            Console.WriteLine("The total numeral value is:");
            Console.WriteLine(output.Numeral);

            Console.WriteLine();
            Console.WriteLine("Press enter to exit");
            string end = Console.ReadLine();

            
        }
    }
}
