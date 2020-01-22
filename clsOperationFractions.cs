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

        //Declare Variables
        private string tFraction = "1/1"; public string TFraction { get => tFraction; set => tFraction = value; }
        private int denominator1;  public int Denominator1 { get => denominator1; set => denominator1 = value; }
        private int numerator1; public int Numerator1 { get => numerator1; set => numerator1 = value; }
        private int denominator2; public int Denominator2 { get => denominator2; set => denominator2 = value; }
        private int numerator2; public int Numerator2 { get => numerator2; set => numerator2 = value; }
        private int newDenominator; public int NewDenominator { get => newDenominator; set => newDenominator = value; }
        private int newNumerator; public int NewNumerator { get => newNumerator; set => newNumerator = value; }

        //Operation Methods
        public string OperationAddition(params string[] fractions)
        {
            for (int i = 0; i != fractions.Length; i++)
            {
                //Separate numerator and denominator
                (Numerator1, Denominator1) = SeparateNumbers(TFraction);
                (Numerator2, Denominator2) = SeparateNumbers(fractions[i]);

                //Operation
                NewDenominator = Denominator1 * Denominator2;
                NewNumerator = Numerator2 * Denominator1 + Numerator1 * Denominator2;

                //Convert to String
                TFraction = NewNumerator + "/" + NewDenominator;

                //Simplify
                TFraction = Simplify(TFraction);
            }

            return TFraction;

        }

        public string OperationSubstraction(params string[] fractions)
        {
            for (int i = 0; i != fractions.Length; i++)
            {
                //Separate numerator and denominator
                (Numerator1, Denominator1) = SeparateNumbers(TFraction);
                (Numerator2, Denominator2) = SeparateNumbers(fractions[i]);

                //Operation
                NewDenominator = Denominator1 * Denominator2;
                NewNumerator = Numerator2 * Denominator1 - Numerator1 * Denominator2;

                //Convert to String
                TFraction = NewNumerator + "/" + NewDenominator;

                //Simplify
                TFraction = Simplify(TFraction);
            }

            return TFraction;
        }

        public string OperationMultiplication(params string[] fractions)
        {
            for (int i = 0; i != fractions.Length; i++)
            {
                //Separate numerator and denominator
                (Numerator1, Denominator1) = SeparateNumbers(TFraction);
                (Numerator2, Denominator2) = SeparateNumbers(fractions[i]);

                //Operation
                NewDenominator = Denominator1 * Denominator2;
                NewNumerator = Numerator1 * Numerator2;

                //Convert to String
                TFraction = NewNumerator + "/" + NewDenominator;

                //Simplify
                TFraction = Simplify(TFraction);
            }

            return TFraction;
        }

        public string OperationDivition(params string[] fractions)
        {
            for (int i = 0; i != fractions.Length; i++)
            {
                //Separate numerator and denominator
                (Numerator1, Denominator1) = SeparateNumbers(TFraction);
                (Numerator2, Denominator2) = SeparateNumbers(fractions[i]);

                //Operation
                NewDenominator = Denominator2 * Numerator1;
                NewNumerator = Denominator1 * Numerator2;

                //Convert to String
                TFraction = NewNumerator + "/" + NewDenominator;

                //Simplify
                TFraction = Simplify(TFraction);
            }

            return TFraction;
        }
    }
}
