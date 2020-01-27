using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace Fractions
{
    static class Reader
    {

        static string text = File.ReadAllText(@"C:\Users\luqui\projects\fractions\interfaceText.txt");
        static string[] lines = text.Split("\n");
        private static string temporalString; private static string TemporalString { get => temporalString; set => temporalString = value; }
        private static ConsoleKeyInfo input; public static ConsoleKeyInfo Input { get => input; set => input = value; }
        private const int waitingTime = 0; private static int WaitingTime => waitingTime;

        static public void Text(int startIndex, int endIndex)
        {
            startIndex--; endIndex--;

            for(int i = startIndex; i <= endIndex; i++)
            {
                TemporalString = lines[i] + "\n";

                for (int j = 0; j < TemporalString.Length; j++)
                {
                    if(TemporalString[j] != ':')
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

    }
}
