using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1346();
            //Test1652();
            //Test1455();
            //Test2109();
            Test2825();
        }

        static void Test1346()
        {
            var leetCode1346 = new LeetCode1346();

            // Example arrays to test the method
            int[] testArray1 = { 10, 2, 5, 3 };
            int[] testArray2 = { 7, 1, 14, 11 };
            int[] testArray3 = { 3, 1, 7, 11 };
            int[] testArray4 = { -2, 0, 10, -19, 4, 6, -8 };

            // Test the method and print results
            Console.WriteLine("Testing 1346: Check if N and its double exist");
            Console.WriteLine($"Test Array 1: {ArrayToString(testArray1)}");
            Console.WriteLine($"Result: {leetCode1346.CheckIfExist(testArray1)}");

            Console.WriteLine($"Test Array 2: {ArrayToString(testArray2)}");
            Console.WriteLine($"Result: {leetCode1346.CheckIfExist(testArray2)}");

            Console.WriteLine($"Test Array 3: {ArrayToString(testArray3)}");
            Console.WriteLine($"Result: {leetCode1346.CheckIfExist(testArray3)}");

            Console.WriteLine($"Test Array 4: {ArrayToString(testArray4)}");
            Console.WriteLine($"Result: {leetCode1346.CheckIfExist(testArray4)}");
            Console.WriteLine();
        }

        static void Test1652()
        {
            var leetCode1652 = new LeetCode1652();

            // Example arrays to test the method
            int[] code1 = { 5, 7, 1, 4 };
            int k1 = 3;

            int[] code2 = { 1, 2, 3, 4 };
            int k2 = 0;

            int[] code3 = { 2, 4, 9, 3 };
            int k3 = -2;

            // Test the method and print results
            Console.WriteLine("Testing 1652: Defuse the bomb");
            Console.WriteLine($"Code 1: {ArrayToString(code1)}, K: {k1}");
            Console.WriteLine($"Decrypted: {ArrayToString(leetCode1652.Decrypt(code1, k1))}");

            Console.WriteLine($"Code 2: {ArrayToString(code2)}, K: {k2}");
            Console.WriteLine($"Decrypted: {ArrayToString(leetCode1652.Decrypt(code2, k2))}");

            Console.WriteLine($"Code 3: {ArrayToString(code3)}, K: {k3}");
            Console.WriteLine($"Decrypted: {ArrayToString(leetCode1652.Decrypt(code3, k3))}");
            Console.WriteLine();
        }

        static void Test1455()
        {
            var leetCode1455 = new LeetCode1455();

            // Test cases for IsPrefixOfWord
            string sentence1 = "i love eating burger";
            string searchWord1 = "burg";

            string sentence2 = "this problem is an easy problem";
            string searchWord2 = "pro";

            string sentence3 = "i am tired";
            string searchWord3 = "you";

            string sentence4 = "hello from the other side";
            string searchWord4 = "hello";

            string sentence5 = "welcome to the jungle";
            string searchWord5 = "jung";

            // Test the method and print results
            Console.WriteLine("Testing 1455: Check if word is prefix of sentence");
            Console.WriteLine($"Sentence: \"{sentence1}\", Search Word: \"{searchWord1}\"");
            Console.WriteLine($"Result: {leetCode1455.IsPrefixOfWord(sentence1, searchWord1)}");

            Console.WriteLine($"Sentence: \"{sentence2}\", Search Word: \"{searchWord2}\"");
            Console.WriteLine($"Result: {leetCode1455.IsPrefixOfWord(sentence2, searchWord2)}");

            Console.WriteLine($"Sentence: \"{sentence3}\", Search Word: \"{searchWord3}\"");
            Console.WriteLine($"Result: {leetCode1455.IsPrefixOfWord(sentence3, searchWord3)}");

            Console.WriteLine($"Sentence: \"{sentence4}\", Search Word: \"{searchWord4}\"");
            Console.WriteLine($"Result: {leetCode1455.IsPrefixOfWord(sentence4, searchWord4)}");

            Console.WriteLine($"Sentence: \"{sentence5}\", Search Word: \"{searchWord5}\"");
            Console.WriteLine($"Result: {leetCode1455.IsPrefixOfWord(sentence5, searchWord5)}");
            Console.WriteLine();
        }

        static void Test2109()
        {
            var leetCode2109 = new LeetCode2109();

            // Test cases for AddSpaces
            string s1 = "EnjoyYourCoffee";
            int[] spaces1 = { 5, 9 };

            string s2 = "HelloWorld";
            int[] spaces2 = { 5 };

            string s3 = "InsertSpacesHere";
            int[] spaces3 = { 6, 12 };

            string s4 = "NoSpacesToAdd";
            int[] spaces4 = { };

            // Test the method and print results
            Console.WriteLine("Testing 2109: Adding Spaces to a String");
            Console.WriteLine($"Input: \"{s1}\", Spaces: {ArrayToString(spaces1)}");
            Console.WriteLine($"Result: \"{leetCode2109.AddSpaces(s1, spaces1)}\"");

            Console.WriteLine($"Input: \"{s2}\", Spaces: {ArrayToString(spaces2)}");
            Console.WriteLine($"Result: \"{leetCode2109.AddSpaces(s2, spaces2)}\"");

            Console.WriteLine($"Input: \"{s3}\", Spaces: {ArrayToString(spaces3)}");
            Console.WriteLine($"Result: \"{leetCode2109.AddSpaces(s3, spaces3)}\"");

            Console.WriteLine($"Input: \"{s4}\", Spaces: {ArrayToString(spaces4)}");
            Console.WriteLine($"Result: \"{leetCode2109.AddSpaces(s4, spaces4)}\"");
            Console.WriteLine();
        }

        static void Test2825()
        {
            var leetCode2825 = new LeetCode2825();

            // Test cases
            string str1_1 = "abc";
            string str2_1 = "acd";

            string str1_2 = "ab";
            string str2_2 = "z";

            string str1_3 = "zab";
            string str2_3 = "abc";

            string str1_4 = "xyz";
            string str2_4 = "ayz";

            string str1_5 = "aaaa";
            string str2_5 = "a";

            string str1_6 = "a";
            string str2_6 = "b";

            // Print results
            Console.WriteLine("Testing 2825: Can Make Subsequence");
            Console.WriteLine($"str1: \"{str1_1}\", str2: \"{str2_1}\" -> Result: {leetCode2825.CanMakeSubsequence(str1_1, str2_1)}");
            Console.WriteLine($"str1: \"{str1_2}\", str2: \"{str2_2}\" -> Result: {leetCode2825.CanMakeSubsequence(str1_2, str2_2)}");
            Console.WriteLine($"str1: \"{str1_3}\", str2: \"{str2_3}\" -> Result: {leetCode2825.CanMakeSubsequence(str1_3, str2_3)}");
            Console.WriteLine($"str1: \"{str1_4}\", str2: \"{str2_4}\" -> Result: {leetCode2825.CanMakeSubsequence(str1_4, str2_4)}");
            Console.WriteLine($"str1: \"{str1_5}\", str2: \"{str2_5}\" -> Result: {leetCode2825.CanMakeSubsequence(str1_5, str2_5)}");
            Console.WriteLine($"str1: \"{str1_6}\", str2: \"{str2_6}\" -> Result: {leetCode2825.CanMakeSubsequence(str1_6, str2_6)}");
            Console.WriteLine();
        }

        static string ArrayToString(int[] arr)
        {
            return "[" + string.Join(", ", arr) + "]";
        }
    }
}
