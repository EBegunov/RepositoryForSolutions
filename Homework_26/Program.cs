using System;
using System.Linq;

/*
@https://www.codewars.com/kata/52597aa56021e91c93000cb0/train/csharp
Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
*/

namespace Homework_26
{

    public class Kata
    {
        public static int[] MoveZeroes(int[] arr)
        {
            //int[] a = Array.FindAll(arr, x => x == 0);

            //Console.WriteLine(a);

            arr = arr.Where(val => val != 0).Concat(Array.FindAll(arr, x => x == 0)).ToArray();

            Math.Sqrt(n);


            foreach (var i in arr)
            {
                Console.Write(i);
            }

            return arr;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kata.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });
            

        }
    }
}
