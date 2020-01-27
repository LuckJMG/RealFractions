using System;

namespace Fractions
{
    static class Program
    {
        static void Main(string[] args)
        {
            //Variables
            bool restart = true;
            string fraction;
            string exercise;

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
                        Console.Write("Insert a fraction: "); fraction = FractionObject.Simplify(Console.ReadLine());
                        Console.WriteLine("\nThe simplified fraction is: {0}", fraction);
                        Console.WriteLine("Do you want to continue? \nz) yes \nx) no\n");
                        Console.Write("Insert character: "); Reader.Input = Console.ReadKey(); Console.Write("\n\n");
                        switch (Reader.Input.Key)
                        {
                            case ConsoleKey.Z:
                                break;

                            case ConsoleKey.X:
                                Reader.Text(33, 35);
                                restart = false;
                                break;

                            default: //Pendiente
                                break;
                        }
                        break;

                    case ConsoleKey.B: //Convert a fraction
                        Reader.Text(21, 27);
                        switch (Reader.Input.Key)
                        {
                            default:
                                break;
                        }//Pendiente
                        break;

                    case ConsoleKey.C: //Operate with fractions
                        Console.Write("Insert exercise: "); exercise = Console.ReadLine(); Console.WriteLine();
                        //Pendiente
                        break;

                    case ConsoleKey.X: //Exit
                        Reader.Text(34, 36);
                        restart = false;
                        break;

                    default: //Other cases
                        Reader.Text(39, 40);
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
