using System;
using System.Text;

namespace LeetCode
{
    public class LeetCode2109
    {
        public string AddSpaces(string s, int[] spaces)
        {
            StringBuilder result = new StringBuilder();
            int spaceIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                // Insert a space if the current index matches a space index
                if (spaceIndex < spaces.Length && i == spaces[spaceIndex])
                {
                    result.Append(' ');
                    spaceIndex++;
                }
                // Add the current character
                result.Append(s[i]);
            }
            return result.ToString();
        }
    }
}
