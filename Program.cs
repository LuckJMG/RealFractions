using System;

namespace Fractions
{
    static class Program
    {
        static void Main(string[] args)
        {
            //Variables
            bool restart = true;
            string temporalNumber;
            string exercise;
            int nDecimal;

            //Instance Objects
            clsFractions FractionObject = new clsFractions();
            clsConvertFractions ConvertFraction = new clsConvertFractions();
            clsOperationFractions OperationFraction = new clsOperationFractions();

            //Start program
            while (restart)
            {
                //Start
                Reader.Text(3, 13);

                //Select answer
                switch (Reader.Input.Key)
                {
                    case ConsoleKey.A: //Simplify a fraction
                        Console.Write("Insert a fraction: "); temporalNumber = FractionObject.Simplify(Console.ReadLine());
                        Console.WriteLine($"\nThe simplified fraction is: {temporalNumber}");
                        break;

                    case ConsoleKey.B: //Convert a fraction
                        Console.WriteLine();
                        Reader.Text(21, 27);
                        switch (Reader.Input.Key)
                        {
                            case ConsoleKey.A: // Fraction to decimal
                                Console.Write("Insert a fraction: "); temporalNumber = Console.ReadLine();
                                Console.Write("Insert number of decimals: "); nDecimal = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine($"The decimal is: {ConvertFraction.FractionToDecimal(temporalNumber, nDecimal)}\n");
                                break;
                            case ConsoleKey.B: // Decimal to fraction
                                Console.Write("Insert a decimal: "); temporalNumber = Console.ReadLine();
                                Console.WriteLine($"The fraction is: {ConvertFraction.DecimalToFraction(Convert.ToDouble(temporalNumber))}\n");
                                break;
                            case ConsoleKey.C: // Fraction to mixed number
                                Console.Write("Insert a fraction: "); temporalNumber = Console.ReadLine();
                                Console.WriteLine($"The mixed number is: {ConvertFraction.FractionToMixedNumber(temporalNumber)}\n");
                                break;
                            case ConsoleKey.D: // Mixed number to fraction
                                Console.Write("Insert a mixed number: "); temporalNumber = Console.ReadLine();
                                Console.WriteLine($"The fraction is: {ConvertFraction.MixedNumberToFraction(temporalNumber)}\n");
                                break;
                            default: // Other cases
                                Reader.Text(44, 45);
                                Console.WriteLine();
                                break;
                        }
                        break;

                    case ConsoleKey.C: //Operate with fractions
                        Console.WriteLine();
                        Reader.Text(30, 36);
                        switch (Reader.Input.Key)
                        {
                            case ConsoleKey.A: // Addition
                                Console.Write("Insert fractions to add them: "); exercise = Console.ReadLine();
                                string[] fractions = exercise.Split(' ');
                                Console.WriteLine($"The answer is: {OperationFraction.OperationAddition(fractions)}\n");
                                break;
                            case ConsoleKey.B: // Subtraction
                                Console.Write("Insert fractions to subtract them: "); exercise = Console.ReadLine();
                                fractions = exercise.Split(' ');
                                Console.WriteLine($"The answer is: {OperationFraction.OperationSubtraction(fractions)}\n");
                                break;
                            case ConsoleKey.C: // Multiplication
                                Console.Write("Insert fractions to multiply them: "); exercise = Console.ReadLine();
                                fractions = exercise.Split(' ');
                                Console.WriteLine($"The answer is: {OperationFraction.OperationMultiplication(fractions)}\n");
                                break;
                            case ConsoleKey.D: // Division
                                Console.Write("insert fractions to divide them: "); exercise = Console.ReadLine();
                                fractions = exercise.Split(' ');
                                Console.WriteLine($"The answer is: {OperationFraction.OperationDivision(fractions)}\n");
                                break;
                            default: // Other cases
                                Reader.Text(44, 45);
                                Console.WriteLine();
                                break;
                        }
                        break;

                    case ConsoleKey.X: //Exit
                        Reader.Text(39, 41);
                        restart = false;
                        break;

                    default: //Other cases
                        Reader.Text(44, 45);
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
