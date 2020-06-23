using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Algorithms!");
            int[] arrayOne = { 10, 2, 5, 3, 9, 7, 0, 1 };
            int[] arrayTwo = { 10, 2, 5, 3, 9, 7, 0, 1 };
            arrayOne = Sorting.InsertionSort(arrayOne);
            arrayTwo = Sorting.InsertionSort(arrayTwo);
        }
    }
}
