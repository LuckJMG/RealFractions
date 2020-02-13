using System;
using System.Collections.Generic;
using System.Text;

namespace Fractions
{
    class clsOperationFractions : clsFractions
    {
        //Builder
        public clsOperationFractions()
        {
        }

        //Operation Methods
        public string OperationAddition(params string[] fractions)
        {
            //Declare variables
            int newDenominator;
            int newNumerator;
            string temporalFraction = "0/1";

            for (int i = 0; i != fractions.Length; i++)
            {
                if (i != 0)
                {
                    //If the solution don't give 0
                    if (ZeroChecker(temporalFraction, fractions[i]))
                    {
                        //Separate numerator and denominator
                        (int numerator1, int denominator1) = SeparateNumbers(temporalFraction);
                        (int numerator2, int denominator2) = SeparateNumbers(fractions[i]);

                        //Operation
                        newDenominator = numerator1 * denominator2;
                        newNumerator = numerator1 * denominator2 + numerator2 * denominator1;

                        //Convert to String
                        temporalFraction = newNumerator + "/" + newDenominator;

                        //Simplify
                        temporalFraction = Simplify(temporalFraction);
                    }
                    //If the solution gives 0
                    else
                    {
                        temporalFraction = "0/1";
                    }
                }
                //Declare the first value
                else { temporalFraction = fractions[0]; }
            }

            //If the result gives 0
            if (temporalFraction != "0/1")
            { return temporalFraction; }
            else
            { return "0"; }
        }
        public string OperationSubtraction(params string[] fractions)
        {
            //Declare variables
            int newDenominator;
            int newNumerator;
            string temporalFraction = "0/1";

            for (int i = 0; i != fractions.Length; i++)
            {
                if (i != 0)
                {
                    if (!ZeroChecker(temporalFraction, fractions[i]))
                    {
                        //Separate numerator and denominator
                        (int numerator1, int denominator1) = SeparateNumbers(temporalFraction);
                        (int numerator2, int denominator2) = SeparateNumbers(fractions[i]);

                        //Operation
                        newDenominator = denominator1 * denominator2;
                        newNumerator = numerator1 * denominator2 - numerator2 * denominator1;

                        //Convert to String
                        temporalFraction = newNumerator + "/" + newDenominator;

                        //Simplify
                        temporalFraction = Simplify(temporalFraction);
                    }
                    else
                    {
                        temporalFraction = "0/1";
                    }
                }
                else { temporalFraction = fractions[0]; }
            }

            if (temporalFraction != "0/1")
            { return temporalFraction; }
            else
            { return "0"; }
        }
        public string OperationMultiplication(params string[] fractions)
        {
            //Declare variables
            int newDenominator;
            int newNumerator;
            string temporalFraction = "1/1";

            for (int i = 0; i != fractions.Length; i++)
            {
                if (i != 0)
                {
                    //Separate numerator and denominator
                    (int numerator1, int denominator1) = SeparateNumbers(temporalFraction);
                    (int numerator2, int denominator2) = SeparateNumbers(fractions[i]);

                    //Operation
                    newDenominator = denominator1 * denominator2;
                    newNumerator = numerator1 * numerator2;

                    //Convert to String
                    temporalFraction = newNumerator + "/" + newDenominator;

                    //Simplify
                    temporalFraction = Simplify(temporalFraction);
                } else { temporalFraction = fractions[0]; }
            }

            return temporalFraction;
        }
        public string OperationDivision(params string[] fractions)
        {
            //Declare variables
            int newDenominator;
            int newNumerator;
            string temporalFraction = "1/1";

            for (int i = 0; i != fractions.Length; i++)
            {
                if (i != 0)
                {
                    //Separate numerator and denominator
                    (int numerator1, int denominator1) = SeparateNumbers(temporalFraction);
                    (int numerator2, int denominator2) = SeparateNumbers(fractions[i]);

                    //Operation
                    newNumerator = denominator2 * numerator1;
                    newDenominator = denominator1 * numerator2;

                    //Convert to String
                    temporalFraction = newNumerator + "/" + newDenominator;

                    //Simplify
                    temporalFraction = Simplify(temporalFraction);
                }
                else { temporalFraction = fractions[0]; }
            }

            return temporalFraction;
        }

    }
}
