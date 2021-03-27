using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Первая попытка реализовать задачу про FizzBuzz    

            int count = 1;
            
            while (count <= 100) 
            {
                if (count % 3 == 0 && count % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    count++;
                }
                else if (count % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    count++;
                }
                else if (count % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    count++;
                }
                else 
                {
                    Console.WriteLine(count);
                    count++;
                }
            }
        }
    }
}
