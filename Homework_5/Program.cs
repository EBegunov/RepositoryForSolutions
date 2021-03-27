using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenNumeric = 0;
            int oddNumeric = 0;
            int startRange, endRange, allNumeric, count;
            int evenSum = 0;
            int oddSum = 0;
            
            Console.WriteLine("Введите начальное число диапазона");
            startRange = int.Parse(Console.ReadLine());
            count = startRange;

            Console.WriteLine("Введите конечное число диапазона");
            endRange = int.Parse(Console.ReadLine());

            while (count < endRange)
            {
                if (count % 2 == 0)
                {
                    evenSum = evenSum + evenNumeric;
                    evenNumeric++;
                    count++;
                }
                else
                {
                    oddSum = oddSum + oddNumeric;
                    oddNumeric++;
                    count++;
                }
            }

            Console.WriteLine($"В диапозоне от {startRange} до {endRange}: четных чисел {evenNumeric} шт. Сумма четных чисел составляет {evenSum}");
            Console.WriteLine($"В диапозоне от {startRange} до {endRange}: нечетных чисел {oddNumeric} шт. Сумма нечетных чисел составляет {oddSum}");

        }
    }
}
