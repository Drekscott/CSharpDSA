using System;
namespace SortingAlgorithms
{
    public static class Sorting
    {
        private static int n;
        private static int i;
        private static bool swapped;
        private static int[] numberArray;

        public static int[] BubbleSort(int[] _array)
        {
            numberArray = _array;
            n = numberArray.Length;
            do
            {
                swapped = false;
                for(i = 0; i < n - 1; i++)
                {
                    if(numberArray[i] > numberArray[i + 1])
                    {
                        Swap(i, i + 1);
                        swapped = true;
                    }
                }

            } while (swapped == true);
            WriteToConsole();
            return numberArray;
        }
        public static int[] InsertionSort(int[] _array)
        {
            numberArray = _array;
            n = numberArray.Length;
            int insertionValue = 0;
            for(i = 0; i < n; i++)
            {
                insertionValue = numberArray[i];
                int j = i;
                while (j > 0 && numberArray[j - 1] > insertionValue)
                {
                    numberArray[j] = numberArray[j - 1];
                    j--;
                }
                numberArray[j] = insertionValue;
            }
            WriteToConsole();
            return numberArray;
        }
        private static void Swap(int indexX, int indexY)
        {
            int temp = numberArray[indexX];
            numberArray[indexX] = numberArray[indexY];
            numberArray[indexY] = temp;
            Console.WriteLine("Values Swapped!");
        }
        private static void WriteToConsole()
        {
            Console.WriteLine("[{0}]", string.Join(", ", numberArray));

        }

    }
}
