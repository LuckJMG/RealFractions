using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace Fractions
{
    static class Reader
    {
        // Declare variables
        static string text = File.ReadAllText(@"C:\Users\luqui\projects\fractions\interface\interfaceText.txt");
        static string[] lines = text.Split("\n");
        private static string temporalString; private static string TemporalString { get => temporalString; set => temporalString = value; }
        private static ConsoleKeyInfo input; public static ConsoleKeyInfo Input { get => input; set => input = value; }
        private const int waitingTime = 0; private static int WaitingTime => waitingTime;
        private static string checker; public static string Checker { get => checker; set => checker = value; }

        // Reader methods
        static public void Text(int startIndex, int endIndex)
        {
            startIndex--; endIndex--;

            for (int i = startIndex; i <= endIndex; i++)
            {
                TemporalString = lines[i] + "\n";

                for (int j = 0; j < TemporalString.Length; j++)
                {
                    if (TemporalString[j] != ':')
                    {
                        Console.Write(TemporalString[j]);
                        Thread.Sleep(WaitingTime);
                    }
                    else
                    {
                        Console.Write(": ");
                        Input = Console.ReadKey();
                    }
                }
            }
        }

        // Checkers methods
        static private bool FractionWithNumbers(string fraction)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j<10; j++)
                {
                    if (fraction.Contains($"{j}/{i}"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static public string FractionChecker()
        {
            bool restart = true;
            string input = "";
            while (restart)
            {
                input = Console.ReadLine();
                if (FractionWithNumbers(input))
                {
                    restart = false;
                    return input;
                }
            }
            return input;
        }
        static public string NumberChecker()
        {
            bool restart = true;
            string input = "";
            while (restart)
            {
                input = Console.ReadLine();
                if (input.Contains(','))
                {
                    restart = false;
                    return input;
                }
            }
            return input;
        }
    }
}
