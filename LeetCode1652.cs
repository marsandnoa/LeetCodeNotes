using System;

namespace LeetCode
{
    public class LeetCode1652
    {
        public int SumInterval(int[] code, int k, int index)
        {
            int sum = 0;
            int n = code.Length;
            int direction = k > 0 ? 1 : -1;

            for (int i = 1; i <= Math.Abs(k); i++)
            {
                int resolvedIndex = (index + direction * i + n) % n;

                sum += code[resolvedIndex];
            }
            return sum;
        }

        public int[] Decrypt(int[] code, int k)
        {
            int[] tempArray = new int[code.Length];
            Array.Copy(code, tempArray, code.Length);

            if (k == 0)
            {
                return new int[code.Length];
            }

            for (int i = 0; i < code.Length; i++)
            {
                tempArray[i] = SumInterval(code, k, i);
            }
            return tempArray;
        }
    }
}
