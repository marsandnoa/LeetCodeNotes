using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //1346. Check if N and its double exist
            var leetCode1346 = new LeetCode1346();

            // Example arrays to test the method
            int[] testArray1 = { 10, 2, 5, 3 };
            int[] testArray2 = { 7, 1, 14, 11 };
            int[] testArray3 = { 3, 1, 7, 11 };
            int[] testArray4 = { -2, 0, 10, -19, 4, 6, -8 };

            // Test the method and print results
            Console.WriteLine($"Test Array 1: {ArrayToString(testArray1)}");
            Console.WriteLine($"Result: {leetCode1346.CheckIfExist(testArray1)}");

            Console.WriteLine($"Test Array 2: {ArrayToString(testArray2)}");
            Console.WriteLine($"Result: {leetCode1346.CheckIfExist(testArray2)}");

            Console.WriteLine($"Test Array 3: {ArrayToString(testArray3)}");
            Console.WriteLine($"Result: {leetCode1346.CheckIfExist(testArray3)}");

            Console.WriteLine($"Test Array 4: {ArrayToString(testArray4)}");
            Console.WriteLine($"Result: {leetCode1346.CheckIfExist(testArray4)}");

            //1652. Defuse the bomb
            var leetCode1652 = new LeetCode1652();

            // Example arrays to test the method
            int[] code1 = { 5, 7, 1, 4 };
            int k1 = 3;

            int[] code2 = { 1, 2, 3, 4 };
            int k2 = 0;

            int[] code3 = { 2, 4, 9, 3 };
            int k3 = -2;

            // Test the method and print results
            Console.WriteLine($"Code 1: {ArrayToString(code1)}, K: {k1}");
            Console.WriteLine($"Decrypted: {ArrayToString(leetCode1652.Decrypt(code1, k1))}");

            Console.WriteLine($"Code 2: {ArrayToString(code2)}, K: {k2}");
            Console.WriteLine($"Decrypted: {ArrayToString(leetCode1652.Decrypt(code2, k2))}");

            Console.WriteLine($"Code 3: {ArrayToString(code3)}, K: {k3}");
            Console.WriteLine($"Decrypted: {ArrayToString(leetCode1652.Decrypt(code3, k3))}");
        }

        static string ArrayToString(int[] arr)
        {
            return "[" + string.Join(", ", arr) + "]";
        }
    }
}
