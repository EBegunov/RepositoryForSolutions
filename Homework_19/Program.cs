using System;
using System.CodeDom.Compiler;


/*
Итак первый пет-проект.
Задача: написать программу которая поможет "малому" вычислять НОД и НОК для решения домашних заданий 6-го класса
Требования:
1. Должен быть выбор, что именно вычислить НОД или НОК.
2. Должна вычислять НОД и НОК как для двух чисел так и для большего количества (ХЗ ПОКА КАК ЭТО РЕАЛИЗОВАТЬ)
3. Должна быть доступна для интеграции с программой работы с дробями

*/




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


        static void Main(string[] args)
        {
            Console.Write("Введите первое число для нахождения НОД:");
            
            int firstNumeric = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число для нахождения НОД:");

            int secondNumeric = int.Parse(Console.ReadLine());

            int rezultNOD = Program.NOD(firstNumeric, secondNumeric);

            Console.WriteLine();            
            Console.WriteLine($"НОД чисел {firstNumeric} и {secondNumeric} равен: {rezultNOD}");
            Console.WriteLine();
            Console.Write("Для выхода с программы нажмите на любую клавишу");
            Console.ReadKey();
        }
    }
}
