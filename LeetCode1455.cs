using System;

namespace LeetCode
{
    public class LeetCode1455
    {
        public int IsPrefixOfWord(string sentence, string searchWord)
        {
            string[] substrings = sentence.Split(' ');

            for (int i = 0; i < substrings.Length; i++)
            {
                int occurence = substrings[i].IndexOf(searchWord);
                if (occurence == 0)
                {
                    return i + 1;
                }
            }

            return -1;
        }

        public int IsPrefixOfWordGpt(string sentence, string searchWord)
        {
            int wordIndex = 1;
            int searchWordLength = searchWord.Length;

            foreach (var word in sentence.Split(' '))
            {
                if (word.Length >= searchWordLength && word.StartsWith(searchWord))
                {
                    return wordIndex;
                }
                wordIndex++;
            }

            return -1;
        }
    }
}
