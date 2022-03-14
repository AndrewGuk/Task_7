using System.Collections.Generic;

namespace Extentions
{
    public static class Helper
    {
        public static int[] ManualLoadArray(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Printer(i);
                array[i] = Validation();
            }
            return array;
        }
        public static int[] AutoLoadArray(this int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0,100);
            }
            return array;
        }
        public static int[,] AutoLoadArray(this int[,] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = rnd.Next(0, 100);
                }
            }
            return array;
        }
        public static int[,] ManualLoadArray(this int[,] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Printer(i, j);
                    array[i, j] = Validation();
                }
            }
            return array;
        }
        public static void PrintReversArray(this int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            Printer(array);
        }
        public static void PrintMaxElement(this int[,] array)
        {
            int[] temp = new int[array.GetLength(1)];
            List<int> list = new List<int>();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    temp[j] = array[i, j];
                }
                Array.Sort(temp);
                list.Add(temp[temp.Length-1]);
            }
            temp = list.ToArray();
            Printer(temp);
        }

        static int Validation()
        {
            bool userEnterIsInt;
            int receivedValue;
            string usEnter;
            do
            {
                usEnter = Console.ReadLine();
                userEnterIsInt = int.TryParse(usEnter, out receivedValue);
                if (!userEnterIsInt)
                    Error();
            }
            while (!userEnterIsInt);
            receivedValue = int.Parse(usEnter);
            return receivedValue;
        }
        static void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The entered data is incorrect, please try again");
            Console.ResetColor();
        }
        static void Printer(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Your <{i+1}> element is:  <{array[i]}>");
            }
        }
        static void Printer(int x)
        {
            Console.Write($"Please, enter <{x + 1}> value: ");
        }
        static void Printer(int x, int y)
        {
            Console.Write($"Please, enter in <{x + 1}> value <{y + 1}>: ");
        }
    }
}