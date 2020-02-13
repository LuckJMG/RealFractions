using System;
using System.Collections.Generic;
using System.Text;

namespace Fractions
{
    public abstract class clsAbsFractions
    {
        //Separate Numbers
        public (int, int) SeparateNumbers(string fraction)
        {
            string[] numbers = (fraction.Split('/'));
            int numerator = Convert.ToInt32(numbers[0]);
            int denominator = Convert.ToInt32(numbers[1]);
            return (numerator, denominator);
        }

        //Calculate sign
        public string SignFraction(string fraction)
        {
            //Declare variables
            (int denominator, int numerator) = SeparateNumbers(fraction);

            //Check the sign
            if (denominator < 0 && numerator > 0)
            {
                string simplifiedResult = -(numerator) + "/" + Math.Abs(denominator);
                return simplifiedResult;
            }
            else if (denominator < 0 && numerator < 0)
            {
                string simplifiedResult = Math.Abs(numerator) + "/" + Math.Abs(denominator);
                return simplifiedResult;
            }
            else
            {
                string simplifiedResult = (numerator) + "/" + (denominator);
                return simplifiedResult;
            }
        }
        public string SignFraction(int numerator, int denominator)
        {
            //Check the sign
            if (denominator < 0 && numerator > 0)
            {
                string simplifiedResult = -(numerator) + "/" + Math.Abs(denominator);
                return simplifiedResult;
            }
            else if (denominator < 0 && numerator < 0)
            {
                string simplifiedResult = Math.Abs(numerator) + "/" + Math.Abs(denominator);
                return simplifiedResult;
            }
            else
            {
                string simplifiedResult = (numerator) + "/" + (denominator);
                return simplifiedResult;
            }
        }
    }
}
