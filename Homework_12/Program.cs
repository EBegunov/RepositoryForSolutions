using System;

namespace Homework_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива:\t");
            int length = int.Parse(Console.ReadLine());

            int[] myFirstArray = new int[length]; 

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Введите значение {i + 1}-го элемента массивау массива:\t");
                myFirstArray[i] = int.Parse(Console.ReadLine());
            }

            
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{myFirstArray[i]} ");
            }            
        }
    }
}
