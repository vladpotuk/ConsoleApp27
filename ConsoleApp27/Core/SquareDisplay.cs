using System;

namespace ConsoleApp27.Core
{
    public class SquareDisplay
    {
        public static void DisplaySquare(int sideLength, char symbol)
        {
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
