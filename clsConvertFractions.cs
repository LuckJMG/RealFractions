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

            //Calculate  numerator and denominator
            double numerator = number * Math.Pow(10, decimalAmount);
            double denominator = Math.Pow(10, decimalAmount);

            //Simplify and return fraction
            string fraction = numerator + "/" + denominator;
            return Simplify(fraction);
        }

        public string FractionToMixedNumber(string fraction)
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
        
        public string MixedNumberToFraction(string mixedNumber)
        {
            //Declare variables
            int numerator;

            //Separate integer and fractions
            string[] temporalArray = mixedNumber.Split(' ');

            //Separate numerator and denominator
            SeparateNumbers(temporalArray[1]);

            //Calculate numerator
            if (temporalArray[0].Contains('-'))
            {
                numerator = ((Math.Abs(Convert.ToInt32(temporalArray[0])) * Denominator) + Numerator) * -1;
            }
            else
            {
                numerator = (Convert.ToInt32(temporalArray[0]) * Denominator) + Numerator;
            }

            //Simplify and return fraction
            string fraction = numerator + "/" +  Denominator;
            return Simplify(fraction);
        }
    }
}
