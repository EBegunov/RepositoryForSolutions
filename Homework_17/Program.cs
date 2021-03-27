using System;

namespace Homework_17
{
    class Program
    {        
        static void ResizeArray(ref int[] array, int newSize)
        {            
            int[] newArray = new int[newSize];

            if (newSize >= array.Length)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
            }
            else
            {
                for (int i = 0; i < newSize; i++)
                {
                    newArray[i] = array[i];
                }
            }
            
            array = newArray;
        }
        
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5 };
            
            foreach (var item in myArray)
            {
                Console.Write(item + " ");
                
            }
            
            Console.WriteLine();
            ResizeArray(ref myArray, 10);
            
            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            ResizeArray(ref myArray, 4);

            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
