using System;
using System.Collections.Generic;
using System.Text;

namespace Fractions
{
    public abstract class clsAbsFractions
    {
        //Variables
        private string fraction; public string Fraction { get => fraction; set => fraction = value; }
        private string simplifiedResult; public string SimplifiedResult { get => simplifiedResult; set => simplifiedResult = value; }
        private string mixedNumber; public string MixedNumber { get => mixedNumber; set => mixedNumber = value; }
        private string sFraction; public string SFraction { get => sFraction; set => sFraction = value; }
        private string[] numbers; public string[] Numbers { get => numbers; set => numbers = value; }
        private int numerator; public int Numerator { get => numerator; set => numerator = value; }
        private int denominator; public int Denominator { get => denominator; set => denominator = value; }
        private int integer; public int Integer { get => integer; set => integer = value; }
        private double oDecimal; public double ODecimal { get => oDecimal; set => oDecimal = value; }

        //New type fraction
        public string NewFraction(int numerator, int denominator)
        {
            Fraction = numerator + "/" + denominator;
            return Fraction;
        }

        //Separate Numbers
        public (int, int) SeparateNumbers(string fraction)
        {
            Numbers = (fraction.Split('/'));
            Numerator = Convert.ToInt32(Numbers[0]);
            Denominator = Convert.ToInt32(Numbers[1]);
            return (Numerator, Denominator);
        }

        //Calculate sign
        public string SignFraction(string fraction)
        {
            SeparateNumbers(fraction);

            //Check the sign
            if (Denominator < 0 && Numerator > 0)
            {
                SimplifiedResult = -(Numerator) + "/" + Math.Abs(Denominator);
                return SimplifiedResult;
            }
            else if (Denominator < 0 && Numerator < 0)
            {
                SimplifiedResult = Math.Abs(Numerator) + "/" + Math.Abs(Denominator);
                return SimplifiedResult;
            }
            else
            {
                SimplifiedResult = (Numerator) + "/" + (Denominator);
                return SimplifiedResult;
            }
        }
        public string SignFraction(int numerator, int denominator)
        {
            //Check the sign
            if (denominator < 0 && numerator > 0)
            {
                SimplifiedResult = -(numerator) + "/" + Math.Abs(denominator);
                return SimplifiedResult;
            }
            else if (denominator < 0 && numerator < 0)
            {
                SimplifiedResult = Math.Abs(numerator) + "/" + Math.Abs(denominator);
                return SimplifiedResult;
            }
            else
            {
                SimplifiedResult = (numerator) + "/" + (denominator);
                return SimplifiedResult;
            }
        }
    }
}
