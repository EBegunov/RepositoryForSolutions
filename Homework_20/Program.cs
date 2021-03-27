using System;

namespace Homework_19
{
    class Program
    {
        /*
        * Алгоритм Эвклида первый вариант:
        * 1. Большее число делим на меньшее.
        * 2. Если делится без остатка, то меньшее число и есть НОД (следует выйти из цикла).
        * 3. Если есть остаток, то большее число заменяем на остаток от деления.
        * 4. Переходим к пункту 1.
        * Алгоритм Эвклида второй вариант:
        * 1. удостоверяемся что а > b
        * 2. находим а = а - b и сравниваем с b
        * 3. удостоверяемся что а > b, если нет меняем значения местами
        * 4. повторяем пока а не станет равно b
        */

        static int NOD(int a, int b)
        {
            int rezult = 0;

            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    int tempA = a;
                    int tempB = b;
                    a = tempB;
                    b = tempA;
                }
                rezult = a;
            }
            return rezult;
        }

        static int NOK(int a, int b)
        {
            int rezult = a * b / NOD(a, b);

            return rezult;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа вычисления НОД и НОК");

            Console.WriteLine("Если вам нужно вычислить НОД введите <1>, если НОК введите <2>");

            int operation = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    
                    Console.Write("Введите первое число для нахождения НОД:");

                    int firstNumericNOD = int.Parse(Console.ReadLine());

                    Console.Write("Введите второе число для нахождения НОД:");

                    int secondNumeric = int.Parse(Console.ReadLine());

                    int rezultNOD = Program.NOD(firstNumericNOD, secondNumeric);

                    Console.WriteLine();

                    Console.WriteLine($"НОД чисел {firstNumericNOD} и {secondNumeric} равен: {rezultNOD}");
                    
                    Console.ReadKey();
                    
                    break;

                case 2:

                    Console.Write("Введите первое число для нахождения НОК:");

                    int firstNumericNOK = int.Parse(Console.ReadLine());

                    Console.Write("Введите второе число для нахождения НОК:");

                    int secondNumericNOK = int.Parse(Console.ReadLine());

                    int rezultNOK = Program.NOK(firstNumericNOK, secondNumericNOK);

                    Console.WriteLine();

                    Console.WriteLine($"НОK чисел {firstNumericNOK} и {secondNumericNOK} равен: {rezultNOK}");                                       

                    break;

                default:
                    
                    Console.WriteLine("Введена не корректная операция");
                    
                    Console.ReadKey();
                    
                    break;
            }            
            
        }
    }
}