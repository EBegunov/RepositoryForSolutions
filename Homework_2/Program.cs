using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");

            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число");

            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите третье число");

            double c = Convert.ToDouble(Console.ReadLine());

            double addition = a + b + c;
            double multiplication = a * b * c;
            
            Console.WriteLine($"Сумма всех чисел равна {addition}");
            Console.WriteLine($"Произведение всех чисел равно {multiplication}");
            Console.ReadKey();

        }
    }
}
