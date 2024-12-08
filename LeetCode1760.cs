using System;
using System.Text;

namespace LeetCode
{
    public class LeetCode1760
    {
        public int MinimumSize(int[] nums, int maxOperations)
        {
            int left = 1;
            int right = nums.Max();

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (CanDivide(nums, maxOperations, mid))
                {
                    right = mid; // Try smaller penalty
                }
                else
                {
                    left = mid + 1; // Increase penalty
                }
            }

            return left;
        }

        private bool CanDivide(int[] nums, int maxOperations, int maxBagSize)
        {
            int operationsNeeded = 0;

            foreach (int num in nums)
            {
                if (num > maxBagSize)
                {
                    operationsNeeded += (num - 1) / maxBagSize;
                    if (operationsNeeded > maxOperations)
                    {
                        return false;
                    }
                }
            }

            return operationsNeeded <= maxOperations;
        }
    }
}
