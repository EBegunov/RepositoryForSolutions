using System;
using System.Collections.Generic;

/*
Попробуйте объединить некоторые идеи из этого и предыдущих занятий. Расширьте код с числами Фибоначчи, который вы создали.
Напишите и протестируйте код для создания первых 20 чисел в последовательности. Подсказка: 20-е число Фибоначчи — 6765.
Последовательность Фибоначчи, последовательность чисел, начинается с двух единиц. 
Каждое следующее число Фибоначчи — это сумма двух предыдущих чисел.
*/


namespace Homework_15
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> { 1, 1 };

            for (int i = 2; i < 20; i++)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(previous + previous2);
            }

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);


        }
    }
}
