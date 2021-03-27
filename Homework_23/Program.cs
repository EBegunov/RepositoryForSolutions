using System;

namespace Homework_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 6, 7, 8 };

            Console.WriteLine(FirstNonConsecutive(arr));
        }

        public static object FirstNonConsecutive(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] - arr[i - 1] != 1)
                {
                    return arr[i];
                }            
            }
            return null;
        }
    }
}
