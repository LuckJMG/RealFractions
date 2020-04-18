using System;
using System.Collections.Generic;
using System.Text;

namespace Fractions
{
    class clsFractions : clsAbsFractions
    {
        // Builder
        public clsFractions()
        {
        }

        // Simplify Method
        public string Simplify(string fraction)
        {
            //Separate numerator and denominator
            (int numerator, int denominator) =  SeparateNumbers(fraction);

            //Declare Variables
            int res;
            int a = Math.Abs(Math.Max(numerator, denominator));
            int b = Math.Abs(Math.Min(numerator, denominator));

            //M.C.D
            do
            {
                res = b;
                b = a % b;
                a = res;
            } while (b != 0);

            //Check if the fraction is negative
            string simplifiedResult = SignFraction(numerator / a, denominator / a);

            //Return the value
            return simplifiedResult;
        }

        // Zero result checker
        public bool ZeroChecker(string fraction1, string fraction2)
        {
            //Check if the fractions has different sign and same value in order fraction1|fraction2
            if (fraction1.Contains('-') && !fraction2.Contains('-') && fraction1.Trim('-') == fraction2.Trim('-'))
            {
                return false;
            }
            //Check if the fractions has different sign and same value in order fraction2|fraction1
            else if (fraction2.Contains('-') && !fraction1.Contains('-') && fraction1.Trim('-') == fraction2.Trim('-'))
            {
                return false;
            }
            //All the other cases return false
            else
            {
                return true;
            }

        }
    }
}
