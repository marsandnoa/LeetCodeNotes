using System;

namespace LeetCode
{
    public class LeetCode1346
    {
        public bool CheckIfExist(int[] arr)
        {
            var sortedArr = new int[arr.Length];
            Array.Copy(arr, sortedArr, arr.Length);
            Array.Sort(sortedArr);

            for (int i = 0; i < sortedArr.Length; i++)
            {
                int index = GenericUtilities.BinarySearch<int>(GenericUtilities.RemoveAt<int>(sortedArr, i), sortedArr[i] * 2);
                if (index != -1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
