using System;

namespace DEV6A.Algorithms
{
    public class InsertionSort<T> where T : IComparable<T>
    {
        public T[] Perform(T[] array)
        {
            var result = new T[array.Length];
            array.CopyTo(result, 0);

            for (var i = 0; i < result.Length - 1; i++)
            {
                var j = i + 1;
                while (j > 0)
                {
                    if (result[j - 1].CompareTo(result[j]) == 1)
                    {
                        var currentElement = result[j - 1];
                        result[j - 1] = result[j];
                        result[j] = currentElement;
                    }

                    j--;
                }
            }

            return result;
        }
    }
}
