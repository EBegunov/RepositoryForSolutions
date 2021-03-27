using System;

/*
 * Написать програму которая возвращает сумму первой и последней цифр в числе. 
 * Пример
 * 4444 --> 8
 * 
 * Попробывать написать к этой программе пару тестов
 * 
 * 
*/

namespace Homework_16
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numeric = int.Parse(Console.ReadLine());
                double lastNumeric = (double)numeric % 10;
                
                int discharge = 0;
                int tempNumeric = numeric;
                
                while (tempNumeric > 0)
                {
                    tempNumeric /= 10;
                    discharge++;                
                }

                int firstNumeric = numeric / (int)Math.Pow(10, discharge - 1);
                int rezult = (int) (firstNumeric + lastNumeric);

                Console.WriteLine($"Сумма первой и последней цифры в числе {numeric} равен {rezult}");

            }
            catch (System.ArgumentNullException)
            {
                System.Console.Error.WriteLine("No number was entered!");
            }
            catch (System.FormatException)
            {
                System.Console.Error.WriteLine("The specified value is not a valid number!");
            }
            catch (System.OverflowException)
            {
                System.Console.Error.WriteLine("The specified number is too big!");
            }
        }
    }
}
