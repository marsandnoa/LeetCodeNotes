using System;
using System.Collections.Generic;

namespace LeetCode
{
    public static class GenericUtilities
    {
        public static int BinarySearch<T>(T[] array, T target, IComparer<T>? comparer = null)
        {
            if (array == null || array.Length == 0)
            {
                return -1;
            }

            comparer ??= Comparer<T>.Default;
            int left = 0;
            int right = array.Length;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (mid >= array.Length)
                {
                    return -1;
                }
                int comparison = comparer.Compare(target, array[mid]);
                if (comparison == 0)
                {
                    return mid;
                }
                else if (comparison < 0)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }

        public static int BinarySearchIndexInsertion<T>(List<T> list, T target, IComparer<T>? comparer = null)
        {
            comparer ??= Comparer<T>.Default;
            int left = 0;
            int right = list.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                int comparison = comparer.Compare(target, list[mid]);
                if (comparison == 0)
                {
                    return mid;
                }
                else if (comparison < 0)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }


        public static T[] RemoveAt<T>(T[] array, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range");
            }

            T[] result = new T[array.Length - 1];
            Array.Copy(array, 0, result, 0, index); // Copy elements before the index
            Array.Copy(array, index + 1, result, index, array.Length - index - 1); // Copy elements after the index
            return result;
        }
    }
}
