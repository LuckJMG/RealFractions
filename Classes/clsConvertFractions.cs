using System;
using System.Collections.Generic;
using System.Text;

namespace Fractions
{
    class clsConvertFractions : clsFractions
    {
        // Builder
        public clsConvertFractions()
        {
        }

        // Convert Methods
        public double FractionToDecimal(string fraction, int numberDecimal)
        {
            // Separate numbers
            (int denominator, int numerator) = SeparateNumbers(fraction);

            // Calculate decimal
            double newDecimal = numerator / Convert.ToDouble(denominator);

            // Approximate decimal
            newDecimal = Math.Round(newDecimal, numberDecimal, MidpointRounding.AwayFromZero);

            return newDecimal;
        }
        public string DecimalToFraction(double number)
        {
            // Convert Decimal to String
            string[] temporalArray = Convert.ToString(number).Split(',');

            // Count how many decimals has the number
            int decimalAmount = temporalArray[1].Length;

            // Calculate  numerator and denominator
            double numerator = Math.Round(number * Math.Pow(10, decimalAmount), 0);
            double denominator = Math.Pow(10, decimalAmount);

            // Simplify and return fraction
            string fraction = numerator + "/" + denominator;
            return Simplify(fraction);
        }
        public string FractionToMixedNumber(string fraction)
        {
            //Declare variables
            string temporalFraction;

            // Check sign and separate the fraction
            fraction = SignFraction(fraction);
            (int denominator, int numerator) = SeparateNumbers(fraction);

            if (Math.Abs(numerator) > Math.Abs(denominator))
            {
                //Calculate mixed number
                int integer = numerator / denominator;
                numerator %= denominator;
                if (numerator != 0)
                {
                    temporalFraction = numerator + "/" + denominator;
                }
                else
                {
                    temporalFraction = "1/" + denominator;
                }

                //Build and return mixed number
                string mixedNumber = integer + " " + temporalFraction;
                return mixedNumber;
            }
            else
            {
                //Return same fraction
                return fraction;
            }
        }
        public string MixedNumberToFraction(string mixedNumber)
        {
            // Declare variables
            int newNumerator;

            // Separate integer and fractions
            string[] temporalArray = mixedNumber.Split(' ');

            // Separate numerator and denominator
            (int denominator, int numerator) = SeparateNumbers(temporalArray[1]);

            // Calculate numerator
            if (temporalArray[0].Contains('-'))
            {
                newNumerator = ((Math.Abs(Convert.ToInt32(temporalArray[0])) * denominator) + numerator) * -1;
            }
            else
            {
                newNumerator = (Convert.ToInt32(temporalArray[0]) * denominator) + numerator;
            }

            // Simplify and return fraction
            string fraction = newNumerator + "/" +  denominator;
            return Simplify(fraction);
        }
    }
}
