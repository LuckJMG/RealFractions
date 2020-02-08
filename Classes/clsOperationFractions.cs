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
        private string tFraction = "0/1"; public string TFraction { get => tFraction; set => tFraction = value; }
        private string multiplicationFraction = "1/1"; public string MultiplicationFraction { get => multiplicationFraction; set => multiplicationFraction = value; }
        private int denominator1;  public int Denominator1 { get => denominator1; set => denominator1 = value; }
        private int numerator1; public int Numerator1 { get => numerator1; set => numerator1 = value; }
        private int denominator2; public int Denominator2 { get => denominator2; set => denominator2 = value; }
        private int numerator2; public int Numerator2 { get => numerator2; set => numerator2 = value; }
        private int newDenominator; public int NewDenominator { get => newDenominator; set => newDenominator = value; }
        private int newNumerator; public int NewNumerator { get => newNumerator; set => newNumerator = value; }

        //Operation Methods
        public string OperationAddition(params string[] fractions) // resultado 0
        {
            for (int i = 0; i != fractions.Length; i++)
            {
                if (i != 0)
                {
                    if ((fractions[i - 1] != fractions[i]) && (fractions[i - 1] == fractions[i].Trim('-')) || (fractions[i - 1].Trim('-') == fractions[i])) // metodo que verfique si sus absolutos son iguales y devuelva un booleano
                    {
                        //Separate numerator and denominator
                        (Numerator1, Denominator1) = SeparateNumbers(TFraction);
                        (Numerator2, Denominator2) = SeparateNumbers(fractions[i]);

                        //Operation
                        NewDenominator = Denominator1 * Denominator2;
                        NewNumerator = Numerator1 * Denominator2 + Numerator2 * Denominator1;

                        //Convert to String
                        TFraction = NewNumerator + "/" + NewDenominator;

                        //Simplify
                        TFraction = Simplify(TFraction);
                    }
                    else
                    {
                        TFraction = "0/1";
                    }
                }
                else { TFraction = fractions[0]; }
            }

            if (TFraction != "0/1")
            { return TFraction; }
            else
            { return "0"; }
        }

        public string OperationSubtraction(params string[] fractions) // resultado 0
        {
            for (int i = 0; i != fractions.Length; i++)
            {
                if (i != 0)
                {
                    //Separate numerator and denominator
                    (Numerator1, Denominator1) = SeparateNumbers(TFraction);
                    (Numerator2, Denominator2) = SeparateNumbers(fractions[i]);

                    //Operation
                    NewDenominator = Denominator1 * Denominator2;
                    NewNumerator = Numerator1 * Denominator2 - Numerator2 * Denominator1;

                    //Convert to String
                    TFraction = NewNumerator + "/" + NewDenominator;

                    //Simplify
                    TFraction = Simplify(TFraction);
                }
                else{ TFraction = fractions[0]; }
            }

            return TFraction;
        }

        public string OperationMultiplication(params string[] fractions)
        {
            for (int i = 0; i != fractions.Length; i++)
            {
                if (i != 0)
                {
                    //Separate numerator and denominator
                    (Numerator1, Denominator1) = SeparateNumbers(MultiplicationFraction);
                    (Numerator2, Denominator2) = SeparateNumbers(fractions[i]);

                    //Operation
                    NewDenominator = Denominator1 * Denominator2;
                    NewNumerator = Numerator1 * Numerator2;

                    //Convert to String
                    MultiplicationFraction = NewNumerator + "/" + NewDenominator;

                    //Simplify
                    MultiplicationFraction = Simplify(MultiplicationFraction);
                } else { MultiplicationFraction = fractions[0]; }
            }

            return MultiplicationFraction;
        }

        public string OperationDivision(params string[] fractions)
        {
            for (int i = 0; i != fractions.Length; i++)
            {
                if (i != 0)
                {
                    //Separate numerator and denominator
                    (Numerator1, Denominator1) = SeparateNumbers(MultiplicationFraction);
                    (Numerator2, Denominator2) = SeparateNumbers(fractions[i]);

                    //Operation
                    NewNumerator = Denominator2 * Numerator1;
                    NewDenominator = Denominator1 * Numerator2;

                    //Convert to String
                    MultiplicationFraction = NewNumerator + "/" + NewDenominator;

                    //Simplify
                    MultiplicationFraction = Simplify(MultiplicationFraction);
                }
                else { MultiplicationFraction = fractions[0]; }
            }

            return MultiplicationFraction;
        }

    }
}
