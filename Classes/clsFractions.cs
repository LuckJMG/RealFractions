﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fractions
{
    class clsFractions : clsAbsFractions
    {
        //Builder
        public clsFractions()
        {
        }

        //Simplify Method
        public string Simplify(string fraction)
        {
            //Separate numerator and denominator
            SeparateNumbers(fraction);

            //Declare Variables
            int res;
            int a = Math.Abs(Math.Max(Numerator, Denominator));
            int b = Math.Abs(Math.Min(Numerator, Denominator));

            //M.C.D
            do
            {
                res = b;
                b = a % b;
                a = res;
            } while (b != 0);

            //Check if the fraction is negative
            string simplifiedResult = SignFraction(Numerator / a, Denominator / a);

            //Return the value
            return simplifiedResult;
        }

    }
}