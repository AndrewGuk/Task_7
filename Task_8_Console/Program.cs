using System;
using static System.Console;
using Extentions;
using ArrayWorker;


namespace Task_7_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("\t\tHello, this is the 7th task." +
                "\n\tManual filling of a one-dimensional array:");
            Random rnd = new Random();
            var arrayLength = rnd.Next(1, 10);
            var firstArray = ArrayCreator.CreateArray(arrayLength);
            WriteLine($"\tYou have created an array of {arrayLength} elements, let's start filling");
            ResetColor();
            Helper.ManualLoadArray(firstArray);
            ForegroundColor = ConsoleColor.Green;
            WriteLine("\tYou array is:");
            PprintArray(firstArray);

            WriteLine("\tOutput of array elements sorted in descending order:");
            ForegroundColor = ConsoleColor.Cyan;
            Helper.PrintReversArray(firstArray);

            ForegroundColor = ConsoleColor.Green;
            WriteLine("\tAuto filling of a one-dimensional array:");
            arrayLength = rnd.Next(1, 10);
            firstArray = ArrayCreator.CreateArray(arrayLength);
            WriteLine($"\tYou have auto - created anarray of {arrayLength} elements");
            Helper.AutoLoadArray(firstArray);
            PprintArray(firstArray);
            WriteLine("\tOutput of the auto filling array elements sorted in descending order:");
            ForegroundColor = ConsoleColor.Cyan;
            Helper.PrintReversArray(firstArray);

            ForegroundColor = ConsoleColor.Green;
            WriteLine("\tManual creation of a two-dimensional 3x3 array:");
            int[,] secondArray = {
                { rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10) },
                { rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10) },
                { rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10) }
            };
            PrintArray(secondArray);
            WriteLine("\tPrinting the value of the maximum element of each row:");
            ForegroundColor = ConsoleColor.Cyan;
            Helper.PrintMaxElement(secondArray);

            ForegroundColor = ConsoleColor.Green;
            WriteLine("\tManual creation of a two-dimensional array:");
            var arrayHeight = rnd.Next(1, 10);
            arrayLength = rnd.Next(1, 10);
            secondArray = ArrayCreator.CreateArray(arrayLength, arrayHeight);
            WriteLine($"\tYou have created an array of {arrayLength}x{arrayHeight} elements, let's start filling");
            ResetColor();
            Helper.ManualLoadArray(secondArray);
            ForegroundColor = ConsoleColor.Green;
            WriteLine("\tYou array is:");
            PrintArray(secondArray);
            WriteLine("\tPrinting the value of the maximum element of each row:");
            ForegroundColor = ConsoleColor.Cyan;
            Helper.PrintMaxElement(secondArray);

            arrayHeight = rnd.Next(1, 10);
            arrayLength = rnd.Next(1, 10);
            secondArray = ArrayCreator.CreateArray(arrayLength, arrayHeight);
            ForegroundColor = ConsoleColor.Green;
            WriteLine($"\tYou have created an auto-array of {arrayLength}x{arrayHeight} elements, let's start filling");
            ResetColor();
            Helper.AutoLoadArray(secondArray);
            ForegroundColor = ConsoleColor.Green;
            WriteLine("\tYou auto-array is:");
            PrintArray(secondArray);
            WriteLine("\tPrinting the value of the maximum element of each row:");
            ForegroundColor = ConsoleColor.Cyan;
            Helper.PrintMaxElement(secondArray);
            ResetColor();

            void PrintArray(int[,] array)
            {
                ForegroundColor = ConsoleColor.Cyan;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Write($"{array[i, j]} | ");
                    }
                    WriteLine();
                }
                ForegroundColor = ConsoleColor.Green;
            }
            void PprintArray(int[] array)
            {
                ForegroundColor = ConsoleColor.Cyan;
                for (int i = 0; i < array.Length; i++)
                {
                    Write($"{array[i]} |");
                }
                WriteLine();
                ForegroundColor = ConsoleColor.Green;
            }
        }
        
        
    }
}