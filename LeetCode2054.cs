using System;
using System.Text;

namespace LeetCode
{
    public class LeetCode2054
    {
        public int MaxTwoEvents(int[][] events)
        {
            // Sort events by end time
            Array.Sort(events, (a, b) => a[1].CompareTo(b[1]));

            int n = events.Length;
            int maxSum = 0;
            int maxValueSoFar = 0;

            List<int[]> maxValues = new List<int[]>();

            foreach (var e in events)
            {
                int start = e[0], end = e[1], value = e[2];

                int idx = BinarySearch(maxValues, start);

                int currentMax = value;
                if (idx != -1)
                {
                    currentMax += maxValues[idx][1];
                }

                maxSum = Math.Max(maxSum, currentMax);

                maxValueSoFar = Math.Max(maxValueSoFar, value);
                maxValues.Add(new int[] { end, maxValueSoFar });
            }

            return maxSum;
        }

        private int BinarySearch(List<int[]> maxValues, int startTime)
        {
            int left = 0, right = maxValues.Count - 1, result = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (maxValues[mid][0] < startTime)
                {
                    result = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }
    }
}
