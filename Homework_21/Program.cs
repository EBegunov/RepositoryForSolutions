using System;

namespace Homework_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество оценок");

            int length = int.Parse(Console.ReadLine());

            int[] array = new int[length]; 
                        
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Введите {i+1} оценку"); 

                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(averageRating(array));

        }

        public static int averageRating(int[] marks)
        {
            int sum = 0;
            int counter = 0;
            
            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
                counter++;
            }

            int averageRating = sum / counter;

            return averageRating;
        }



    }
}
