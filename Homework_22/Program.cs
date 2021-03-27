using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine(CountBits(n));
            }
            
        }

        public static int CountBits(int n)
        {
            string stringTemp = Convert.ToString(n, 2);

            double longTemp = Convert.ToDouble(stringTemp);

            double tempCount = 0;

            while (longTemp != 0)
            {
                tempCount += longTemp % 10;
                longTemp /= 10;
            }

            return (int)tempCount;
        }
    }
}
