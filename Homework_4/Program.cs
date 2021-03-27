using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumeric;
            double secondNumeric;
                       
            double result = 0;

            string operation;




            Console.WriteLine("Введите первое число");

            firstNumeric = double.Parse(Console.ReadLine());

            Console.WriteLine("Какую операцию следует выполнить");

            operation = Console.ReadLine();

            Console.WriteLine("Введите второе число");

            secondNumeric = double.Parse(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    result = firstNumeric + secondNumeric;
                    break;
                
                case "-":
                    result = firstNumeric - secondNumeric;
                    break;

                case "*":
                    result = firstNumeric * secondNumeric;
                    break;

                case "/":
                    result = firstNumeric / secondNumeric;
                    break;

            }


            Console.WriteLine($"Результат = {result}");


























        }
    }
}
