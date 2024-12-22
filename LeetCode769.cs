using System;
using System.Text;

namespace LeetCode
{
    public class LeetCode769
    {
        public int MaxChunksToSorted(int[] arr)
        {
            int maxSoFar = 0;
            int chunks = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                maxSoFar = Math.Max(maxSoFar, arr[i]);
                if (maxSoFar == i)
                {
                    chunks++;
                }
            }

            return chunks;
        }
    }
}
