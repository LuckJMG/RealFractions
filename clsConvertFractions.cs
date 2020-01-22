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
        public double ConvertToDecimal(string fraction)
        {
            //Separate numbers
            SeparateNumbers(fraction);

            //Calculate Decimal
            ODecimal = Numerator / Convert.ToDouble(Denominator);

            return ODecimal;
        }

        public double ConvertToDecimal(string fraction, int nDecimal)
        {
            //Separate numbers
            SeparateNumbers(fraction);

            //Calculate decimal
            ODecimal = Numerator / Convert.ToDouble(Denominator);

            //Aprox decimal
            ODecimal = Math.Round(ODecimal, nDecimal, MidpointRounding.AwayFromZero);

            return ODecimal;
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
