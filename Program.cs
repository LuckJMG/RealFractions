using System;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            bool restart = true;
            string fraction;
            string exercise;

            //Instance Objects
            clsFractions fractionObject = new clsFractions();
            clsConvertFractions convert = new clsConvertFractions();
            clsOperationFractions operation = new clsOperationFractions();
            //Start program
            while (restart)
            {
                //Start
                print.Text(3, 14);     
                
                //Select answer
                switch (print.Input.Key)
                {
                    case ConsoleKey.A: //Simplify a fraction
                        Console.Write("Insert a fraction: "); fraction = fractionObject.Simplify(Console.ReadLine());
                        Console.WriteLine("The simplified fraction is: {0}", fraction);
                        Console.WriteLine("Do you want to continue? \nz) yes \nx) no");
                        Console.Write("Insert character: "); print.Input = Console.ReadKey(); Console.Write("\n\n");
                        switch (print.Input.Key)
                        {
                            case ConsoleKey.Z:
                                break;

                            case ConsoleKey.X:
                                print.Text(35, 37);
                                restart = false;
                                break;
                        }
                        break;

                    case ConsoleKey.B: //Convert a fraction
                        print.Text(21, 27); 
                        switch (print.Input.Key)
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
                        print.Text(34, 36);
                        restart = false;
                        break;

                    default: //Other cases
                        print.Text(39, 40);
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
