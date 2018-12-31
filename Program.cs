using System;
using System.Diagnostics;

using DEV6A.Algorithms;

namespace DEV6A
{
    class Program
    {
        static int[] unsortedArray = new int[10] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

        static void Main(string[] args)
        {
            // Execute sorting algorithms
            RunInsertionSort(unsortedArray);
            RunMergeSort(unsortedArray);
        }

        static void RunInsertionSort(int[] input)
        {
            var insertionSort = new InsertionSort<int>();

            // Write array before sorting
            Console.WriteLine("\nBefore insertion sort: {0}", string.Join(", ", input));

            // Execute insertion sort
            var result = insertionSort.Perform(input);

            // Write result and execution time
            Console.WriteLine("After insertion sort: {0}", string.Join(", ", result));
        }

        static void RunMergeSort(int[] input)
        {
            var mergeSort = new MergeSort<int>();

            // Write array before sorting
            Console.WriteLine("\nBefore merge sort: {0}", string.Join(", ", input));

            // Execute merge sort
            var result = mergeSort.Perform(input);

            // Write result and execution time
            Console.WriteLine("After merge sort: {0}", string.Join(", ", result));
        }
    }
}
