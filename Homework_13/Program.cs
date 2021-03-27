using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Теперь, когда вы ознакомились с разными числовыми типами, напишите код, который позволяет вычислить
площадь круга с радиусом 2,50 см. Помните, что площадь круга равна квадрату радиуса, умноженному
на число пи. Подсказка: в .NET есть константа пи Math.PI, которую можно использовать. Math.PI, 
как и все константы, объявленные в пространстве имен System.Math, — это значение double. 
По этой причине вместо значений decimal для этой задачи следует использовать double.

Вы должны получить ответ от 19 до 20.
*/



namespace Homework_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaOfACircle = (Math.Pow(2.5, 2)) * Math.PI;

            Console.WriteLine(areaOfACircle);
        }
    }
}
