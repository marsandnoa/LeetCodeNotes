using System;
using System.ComponentModel;
using System.Text;

namespace LeetCode
{
    public class LeetCode494
    {
        public int FindTargetSumWays(int[] nums, int target)
        {
            int s = 0;
            foreach (int num in nums)
                s += num;

            if ((s + target) < 0 || (s + target) % 2 != 0)
                return 0;

            int subsetGoal = (s + target) / 2;

            int[] dp = new int[subsetGoal + 1];
            dp[0] = 1;

            foreach (int num in nums)
            {
                for (int sum = subsetGoal; sum >= num; sum--)
                {
                    dp[sum] += dp[sum - num];
                }
            }

            return dp[subsetGoal];
        }
    }
}
