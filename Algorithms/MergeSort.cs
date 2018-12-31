using System;
using System.Collections.Generic;

namespace DEV6A.Algorithms
{
    public class MergeSort<T> where T : IComparable<T>
    {
        public List<T> Perform(T[] array)
        {
            if (array.Length == 1)
            {
                return new List<T>(array);
            }

            var rightArray = new List<T>();
            var leftArray = new List<T>();

            var middle = array.Length / 2;

            // Insert elements to left array
            for (int i = 0; i < middle; i++)
            {
                leftArray.Add(array[i]);
            }

            // Insert elements to right array
            for (int i = middle; i < array.Length; i++)
            {
                rightArray.Add(array[i]);
            }

            // Perform Merge Sort on both sides
            leftArray = Perform(leftArray.ToArray());
            rightArray = Perform(rightArray.ToArray());

            return Merge(leftArray, rightArray);
        }

        public List<T> Merge(List<T> left, List<T> right)
        {
            var mergedList = new List<T>();

            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0].CompareTo(right[0]) == -1)
                {
                    mergedList.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    mergedList.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            for (int i = 0; i < left.Count; i++)
            {
                mergedList.Add(left[i]);
            }

            for (int i = 0; i < right.Count; i++)
            {
                mergedList.Add(right[i]);
            }

            return mergedList;
        }
    }
}
