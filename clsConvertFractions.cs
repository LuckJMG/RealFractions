using System;
using System.Collections.Generic;
using System.Text;

namespace Fractions
{
    class clsConvertFractions : clsFractions
    {
        //Builder
        public clsConvertFractions()
        {
        }

        //Convert Methods
        public double FractionToDecimal(string fraction)
        {
            //Separate numbers
            SeparateNumbers(fraction);

            //Calculate Decimal
            ODecimal = Numerator / Convert.ToDouble(Denominator);

            return ODecimal;
        }

        public double FractionToDecimal(string fraction, int nDecimal)
        {
            //Separate numbers
            SeparateNumbers(fraction);

            //Calculate decimal
            ODecimal = Numerator / Convert.ToDouble(Denominator);

            //Aprox decimal
            ODecimal = Math.Round(ODecimal, nDecimal, MidpointRounding.AwayFromZero);

            return ODecimal;
        }

        public string DecimalToFraction(double number)
        {
            //Convert Decimal to String
            string[] temporalArray = Convert.ToString(number).Split(',');

            //Count how many decimals has the number
            int decimalAmount = temporalArray[1].Length;

            //Declare Numerator and Denominator
            double numerator = number * Math.Pow(10, decimalAmount);
            double denominator = Math.Pow(10, decimalAmount);

            //Unir Numerator and Denominator
            string fraction = numerator + "/" + denominator;

            //Simplify fraction and return
            fraction = Simplify(fraction);
            return fraction;
        }

        public string ConvertToMixedNumber(string fraction)
        {
            //Separate numbers
            SeparateNumbers(fraction);

            if (Numerator > Denominator)
            {
                //Calculate mixed number
                Integer = Numerator / Denominator;
                SFraction = Numerator % Denominator + "/" + Denominator;
                MixedNumber = Integer + " " + SFraction;

                return MixedNumber;
            }
            else
            {
                //Return same fraction
                return fraction;
            }
        }
    }
}
